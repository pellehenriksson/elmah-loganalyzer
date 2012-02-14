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
		private readonly IErrorLogFileParser _parser;
		private readonly ISettingsManager _settingsManager;
		private readonly ILog _log;
		
		public SqlServerErrorLogSource(string connection, IErrorLogFileParser parser, ISettingsManager settingsManager, ILog log)
		{
			Connection = connection;
			_settingsManager = settingsManager;
			_parser = parser;
			_log = log;
		}

		public string Connection { get; private set; }

		public List<ErrorLog> GetLogs()
		{
			var result = new List<ErrorLog>();
			IEnumerable<string> logs;

			using (IDbConnection connection = new SqlConnection(Connection))
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
