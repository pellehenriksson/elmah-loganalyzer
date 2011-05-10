using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class SqlServerErrorLogSourceService : IErrorLogSourceService
	{
		private readonly IErrorLogFileParser _parser;
		private readonly ISettingsManager _settingsManager;
		private readonly ILog _log;

		public SqlServerErrorLogSourceService(IErrorLogFileParser parser, ISettingsManager settingsManager, ILog log)
		{
			_parser = parser;
			_settingsManager = settingsManager;
			_log = log;
		}

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
			const string selectWithLimit = "SELECT TOP {0} AllXml FROM ELMAH_Error;";
			const string selectAll = "SELECT AllXml FROM ELMAH_Error;";

			return _settingsManager.GetMaxNumberOfLogs() == -1 ? selectAll : selectWithLimit;
		}
	}
}
