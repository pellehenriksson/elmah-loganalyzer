using System.Data;
using System.Data.SqlServerCe;
using Dapper;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.Core.Infrastructure.Logging;

namespace ElmahLogAnalyzer.Core.Domain.Export
{
	public class SqlCeDatabaseCreator : IDatabaseCreator
	{
		private readonly ILog _log;
		private readonly IFileSystemHelper _fileSystemHelper;

		public SqlCeDatabaseCreator(IFileSystemHelper fileSystemHelper, ILog log)
		{
			_fileSystemHelper = fileSystemHelper;
			_log = log;
		}
		
		public void Create(string databasename)
		{
			_log.Debug(string.Format("Creating database: {0}", databasename));

			if (_fileSystemHelper.FileExists(databasename))
			{
				_log.Debug("Deleting current database");
				_fileSystemHelper.DeleteFile(databasename);
			}

			var connectionString = string.Format("Data Source = {0};", databasename);

			using (var engine = new SqlCeEngine(connectionString))
			{
				_log.Debug(string.Format("Creating new database with connectionstring: {0}", connectionString));

				engine.CreateDatabase();

				_log.Debug("Database was created");
			}

			using (IDbConnection connection = new SqlCeConnection(connectionString))
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
