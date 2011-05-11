using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Logging;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class SqlServerErrorLogSource : IErrorLogSource
	{
		private readonly IErrorLogFileParser _parser;
		private readonly ISettingsManager _settingsManager;
		private readonly ILog _log;

		public SqlServerErrorLogSource(IErrorLogFileParser parser, ISettingsManager settingsManager, ILog log, string path)
		{
			_parser = parser;
			_settingsManager = settingsManager;
			_log = log;
			Path = path;
		}

		public string Path { get; private set; }

		public List<ErrorLog> GetLogs(string directory)
		{
			var result = new List<ErrorLog>();

			using (var connection = new SqlConnection(directory))
			{
				connection.Open();

				using (var command = new SqlCommand(ResolveQuery(), connection))
				{
					using (var reader = command.ExecuteReader(CommandBehavior.CloseConnection))
					{
						while (reader.Read())
						{
							var content = reader.GetString(0);
							var log = _parser.Parse(content);
						
							if (log == null)
							{
								// log
								continue;
							}

							result.Add(log);
						}
					}
				}
			}

			return result;
		}

		private string ResolveQuery()
		{
			const string selectWithLimit = "SELECT TOP {0} AllXml FROM ELMAH_Error ORDER BY TimeUtc;";
			const string selectAll = "SELECT AllXml FROM ELMAH_Error ORDER BY TimeUtc;";

			return _settingsManager.GetMaxNumberOfLogs() == -1 ? selectAll : selectWithLimit;
		}
	}
}
