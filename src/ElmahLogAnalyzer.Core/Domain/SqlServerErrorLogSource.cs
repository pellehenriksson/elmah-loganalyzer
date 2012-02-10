using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using ElmahLogAnalyzer.Core.Infrastructure.Logging;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class SqlServerErrorLogSource : IErrorLogSource
	{
		private readonly string _connectionString;
		private readonly IErrorLogFileParser _parser;
		private readonly ISettingsManager _settingsManager;
		private readonly ILog _log;
		
		public SqlServerErrorLogSource(string connectionString, IErrorLogFileParser parser, ISettingsManager settingsManager, ILog log)
		{
			_connectionString = connectionString;
			_settingsManager = settingsManager;
			_parser = parser;
			_log = log;
		}

		public List<ErrorLog> GetLogs(string directory)
		{
			var result = new List<ErrorLog>();
			IEnumerable<string> logs;

			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var query = _settingsManager.GetMaxNumberOfLogs() > -1 ? string.Format("SELECT TOP {0} AllXml FROM [ELMAH_Error] ORDER BY Sequence DESC;", _settingsManager.GetMaxNumberOfLogs()) : "SELECT AllXml FROM [ELMAH_Error] ORDER BY Sequence DESC;";
				logs = connection.Query<string>(query);
			}
			
			foreach (var log in logs)
			{
				var errorLog = _parser.Parse(log);

				if (errorLog == null)
				{
					_log.Error(string.Format("Failed to parse file: {0}", log));
					continue;
				}

				result.Add(errorLog);
			}

			return result;
		}
	}
}
