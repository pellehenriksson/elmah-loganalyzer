using System.Data;
using System.Data.SqlServerCe;
using Dapper;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.Core.Infrastructure.Logging;

namespace ElmahLogAnalyzer.Core.Domain.Export
{
	public class ErrorLogExporter : IErrorLogExporter
	{
		private readonly IErrorLogRepository _repository;
		private readonly IFileSystemHelper _fileSystemHelper;
		private readonly ILog _log;

		public ErrorLogExporter(IErrorLogRepository repository, IFileSystemHelper fileSystemHelper, ILog log)
		{
			_repository = repository;
			_fileSystemHelper = fileSystemHelper;
			_log = log;
		}

		public string ConnectionString { get; private set; }
		
		public int Export()
		{
			CreateStorage();

			var logsInsertedCounter = 0;

			using (IDbConnection connection = new SqlCeConnection(ConnectionString))
			{
				connection.Open();
				foreach (var errorlog in _repository.GetAll())
				{
					logsInsertedCounter += PersistErrorLog(connection, errorlog);

					PersistServerVariables(connection, errorlog);
					PersistFormValues(connection, errorlog);
					PersistCookieValues(connection, errorlog);
					PersistQuerystringValues(connection, errorlog);
					PersistClientInformation(connection, errorlog);
					PersistServerInformation(connection, errorlog);
				}
			}

			return logsInsertedCounter;
		}

		private static int PersistErrorLog(IDbConnection connection, ErrorLog errorlog)
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

			return connection.Execute(sql, parameters);
		}
		
		private static void PersistServerVariables(IDbConnection connection, ErrorLog errorlog)
		{
			foreach (var variable in errorlog.ServerVariables)
			{
				connection.Execute(
					"INSERT INTO ServerVariables (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", 
					new { variable.Name, variable.Value, errorLogId = errorlog.ErrorId });
			}
		}

		private static void PersistFormValues(IDbConnection connection, ErrorLog errorlog)
		{
			foreach (var formValue in errorlog.FormValues)
			{
				connection.Execute(
					"INSERT INTO FormValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", 
					new { formValue.Name, formValue.Value, errorLogId = errorlog.ErrorId });
			}
		}

		private static void PersistCookieValues(IDbConnection connection, ErrorLog errorlog)
		{
			foreach (var cookie in errorlog.Cookies)
			{
				connection.Execute(
					"INSERT INTO CookieValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", 
					new { cookie.Name, cookie.Value, errorLogId = errorlog.ErrorId });
			}
		}

		private static void PersistQuerystringValues(IDbConnection connection, ErrorLog errorlog)
		{
			foreach (var qstring in errorlog.QuerystringValues)
			{
				connection.Execute(
					"INSERT INTO QuerystringValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", 
					new { qstring.Name, qstring.Value, errorLogId = errorlog.ErrorId });
			}
		}
		
		private static void PersistServerInformation(IDbConnection connection, ErrorLog errorlog)
		{
			var serverInfo = errorlog.ServerInformation;
					
			connection.Execute(
				"INSERT INTO ServerInformation (Host, Name, Port, Software, ErrorLogId) VALUES (@host, @name, @port, @software, @errorLogId)",
				new { serverInfo.Host, serverInfo.Name, serverInfo.Port, serverInfo.Software, errorLogId = errorlog.ErrorId });
		}

		private static void PersistClientInformation(IDbConnection connection, ErrorLog errorlog)
		{
			var clientInfo = errorlog.ClientInformation;

			connection.Execute(
				"INSERT INTO ClientInformation (Browser, OperatingSystem, Platform, Description, ErrorLogId) VALUES (@browser, @operatingSystem, @platform, @description, @errorLogId)",
				new { clientInfo.Browser, clientInfo.OperatingSystem, clientInfo.Platform, clientInfo.Description, errorLogId = errorlog.ErrorId });
		}

		private void CreateStorage()
		{
			const string databaseFile = "ElmahLogAnalyzer_Dump.sdf";
			
			_log.Debug(string.Format("Creating database: {0}", databaseFile));

			if (_fileSystemHelper.FileExists(databaseFile))
			{
				_log.Debug("Deleting current database");
				_fileSystemHelper.DeleteFile(databaseFile);
			}

			ConnectionString = string.Format("Data Source = {0};", databaseFile);

			using (var engine = new SqlCeEngine(ConnectionString))
			{
				_log.Debug(string.Format("Creating new database with connectionstring: {0}", ConnectionString));
				
				engine.CreateDatabase();

				_log.Debug("Database was created");
			}

			using (IDbConnection connection = new SqlCeConnection(ConnectionString))
			{
				connection.Open();

				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaErrorLogsTable);
				_log.Debug(string.Format("Created table: {0}", "ErrorLogs"));

				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaServerVariablesTable);
				_log.Debug(string.Format("Created table: {0}", "ServerVariables"));

				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaCookieValuesTable);
				_log.Debug(string.Format("Created table: {0}", "CookieValues"));
				
				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaFormValuesTable);
				_log.Debug(string.Format("Created table: {0}", "FormValues"));
				
				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaQuerystringValuesTable);
				_log.Debug(string.Format("Created table: {0}", "QuerystringValues"));
				
				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaClientInformationTable);
				_log.Debug(string.Format("Created table: {0}", "ClientInformation"));
				
				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaServerInformationTable);
				_log.Debug(string.Format("Created table: {0}", "ServerInformation"));

				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaServerVariablesForeignKeys);
				_log.Debug(string.Format("Created foreign keys for: {0}", "ServerVariables"));

				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaFormValuesForeignKeys);
				_log.Debug(string.Format("Created foreign keys for: {0}", "FormValues"));

				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaCookieValuesForeignKeys);
				_log.Debug(string.Format("Created foreign keys for: {0}", "CookieValues"));

				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaQuerystringValuesForeignKeys);
				_log.Debug(string.Format("Created foreign keys for: {0}", "QuerystringValues"));
				
				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaClientInformationForeignKeys);
				_log.Debug(string.Format("Created foreign keys for: {0}", "ClientInformation"));

				connection.Execute(DatabaseScripts.SqlCeDatabaseSchemaServerInformationForeignKeys);
				_log.Debug(string.Format("Created foreign keys for: {0}", "ServerInformation"));
			}
		}
	}
}
