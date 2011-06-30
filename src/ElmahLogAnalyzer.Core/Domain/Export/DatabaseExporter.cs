using System.Data;
using System.Data.SqlServerCe;
using Dapper;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;

namespace ElmahLogAnalyzer.Core.Domain.Export
{
	public class DatabaseExporter
	{
		private readonly IErrorLogRepository _repository;
		private readonly IFileSystemHelper _fileSystemHelper;

		public DatabaseExporter(IErrorLogRepository repository, IFileSystemHelper fileSystemHelper)
		{
			_repository = repository;
			_fileSystemHelper = fileSystemHelper;
		}

		public string ConnectionString { get; private set; }

		public void CreateStorage(string databaseName)
		{
			var databaseFile = string.Format("{0}.sdf", databaseName);

			if (_fileSystemHelper.FileExists(databaseFile))
			{
				_fileSystemHelper.DeleteFile(databaseFile);
			}

			ConnectionString = string.Format("Data Source = {0};", databaseFile);

			using (var engine = new SqlCeEngine(ConnectionString))
			{
				engine.CreateDatabase();
			}

			using (IDbConnection connection = new SqlCeConnection(ConnectionString))
			{
				connection.Open();
				connection.Execute(Templates.SqlCeDatabaseSchemaErrorLogsTable);
				connection.Execute(Templates.SqlCeDatabaseSchemaServerVariablesTable);
				connection.Execute(Templates.SqlCeDatabaseSchemaCookieValuesTable);
				connection.Execute(Templates.SqlCeDatabaseSchemaFormValuesTable);
				connection.Execute(Templates.SqlCeDatabaseSchemaQuerystringValuesTable);
			}
		}

		public int Export()
		{
			var logsInsertedCounter = 0;

			using (IDbConnection connection = new SqlCeConnection(ConnectionString))
			{
				connection.Open();
				foreach (var errorlog in _repository.GetAll())
				{
					const string sql = @"INSERT INTO ErrorLogs (ErrorId, Host, Type, Message, Source, Details, Time, StatusCode, [User], Url) 
						VALUES (@errorId, @host, @type, @message, @source, @details, @time, @statusCode, @user, @url);";
					
					var parameters = new DynamicParameters();
					parameters.Add("@errorId", errorlog.ErrorId.ToString());
					parameters.Add("@host", errorlog.Host);
					parameters.Add("@type", errorlog.Type);
					parameters.Add("@message", errorlog.Message);
					parameters.Add("@source", errorlog.Source);
					parameters.Add("@details", errorlog.Details);
					parameters.Add("@time", errorlog.Time);
					parameters.Add("@statusCode", errorlog.StatusCode);
					parameters.Add("@user", errorlog.User);
					parameters.Add("@url", errorlog.Url);

					logsInsertedCounter += connection.Execute(sql, parameters);

					foreach (var variable in errorlog.ServerVariables)
					{
						connection.Execute("INSERT INTO ServerVariables (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", new { variable.Name, variable.Value, errorLogId = errorlog.ErrorId });
					}

					foreach (var formValue in errorlog.FormValues)
					{
						connection.Execute("INSERT INTO FormValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", new { formValue.Name, formValue.Value, errorLogId = errorlog.ErrorId });
					}

					foreach (var cookie in errorlog.Cookies)
					{
						connection.Execute("INSERT INTO CookieValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", new { cookie.Name, cookie.Value, errorLogId = errorlog.ErrorId });
					}

					foreach (var qstring in errorlog.QuerystringValues)
					{
						connection.Execute("INSERT INTO QuerystringValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", new { qstring.Name, qstring.Value, errorLogId = errorlog.ErrorId });
					}
				}
			}

			return logsInsertedCounter;
		}
	}
}
