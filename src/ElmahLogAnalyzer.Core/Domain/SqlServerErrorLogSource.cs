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
		
		public SqlServerErrorLogSource(string connection, string schema, string application, IErrorLogFileParser parser, ISettingsManager settingsManager, ILog log)
		{
			Connection = connection;
			Schema = schema;
		    Application = application;
			_settingsManager = settingsManager;
			_parser = parser;
			_log = log;
		}

		public string Connection { get; private set; }

		public string Schema { get; private set; }

	    public string Application { get; set; }

		public List<ErrorLog> GetLogs()
		{
			var result = new List<ErrorLog>();
			IEnumerable<string> logs;

			using (IDbConnection connection = new SqlConnection(Connection))
			{
				connection.Open();

			    var query = string.Format("SELECT {0} [AllXml] FROM {1} {2} ORDER BY [Sequence] DESC", this.ResolveSelectTopClause(), this.ResolveTableName(), this.ResolveApplicationClause());

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

        private string ResolveSelectTopClause()
        {
            if (_settingsManager.GetMaxNumberOfLogs() > -1 )
            {
                return string.Format("TOP {0}", _settingsManager.GetMaxNumberOfLogs());
            }

            return string.Empty;
        }

        private string ResolveApplicationClause()
        {
            if (!string.IsNullOrWhiteSpace(Application))
            {
                return string.Format("WHERE Application = '{0}'", Application);
            }

            return string.Empty;
        }

		private string ResolveTableName()
		{
			return !string.IsNullOrWhiteSpace(Schema) ? string.Format("[{0}].[ELMAH_Error]", Schema) : "[ELMAH_Error]";
		}
	}
}
