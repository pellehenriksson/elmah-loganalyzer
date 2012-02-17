using System;
using System.Collections.Generic;
using System.Linq;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.Core.Common
{
	public static class ConnectionStringHelper
	{
		public static string Extract(IConnectToDatabaseConnectionInformation information)
		{
			switch (information.Source)
			{
				case ErrorLogSources.SqlServer:
				{
					var result = string.Format("Data Source={0};Initial Catalog={1};", information.Server, information.Database);
					if (information.UseIntegratedSecurity)
					{
						result += "Integrated Security=SSPI;";
					}
					else
					{
						result += string.Format("User Id={0};Password={1};", information.Username, information.Password);
					}

					return result;
				}

				case ErrorLogSources.SqlServerCompact:
					{
						return string.Format("Data Source={0};Persist Security Info=False;", information.Server);
					}

				default:
					throw new InvalidOperationException(string.Format("Error log source {0} is not supported", information.Source));
			}
		}

		public static void Apply(IConnectToDatabaseConnectionInformation information, string connectionString)
		{
			var values = BuildDictionary(connectionString);

			information.Server = values.FirstOrDefault(x => x.Key.Equals("server", StringComparison.InvariantCultureIgnoreCase) || x.Key.Equals("data source", StringComparison.InvariantCultureIgnoreCase)).Value;
			information.Database = values.FirstOrDefault(x => x.Key.Equals("database", StringComparison.InvariantCultureIgnoreCase) || x.Key.Equals("initial catalog", StringComparison.InvariantCultureIgnoreCase)).Value;
			information.Username = values.FirstOrDefault(x => x.Key.Equals("user id", StringComparison.InvariantCultureIgnoreCase)).Value;
			information.Password = values.FirstOrDefault(x => x.Key.Equals("password", StringComparison.InvariantCultureIgnoreCase)).Value;
			
			var key =
				values.FirstOrDefault(x => x.Key.Equals("integrated security", StringComparison.InvariantCultureIgnoreCase) || x.Key.Equals("trusted_connection", StringComparison.InvariantCultureIgnoreCase)).Key;

			information.UseIntegratedSecurity = !string.IsNullOrEmpty(key);
		}

		private static Dictionary<string, string> BuildDictionary(string connectionString)
		{
			var keyValuePairs = connectionString.Split(';');
			var values = keyValuePairs
							.Select(keyValue => keyValue.Split('='))
							.Where(temp => temp.Length >= 2)
							.ToDictionary(temp => temp[0].Trim(), temp => temp[1].Trim());
			return values;
		}
	}
}
