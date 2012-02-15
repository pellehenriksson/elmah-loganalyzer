using System;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.Core.Common
{
	public static class ConnectionStringBuilder
	{
		public static string Build(IConnectToDatabaseView connect)
		{
			switch (connect.Source)
			{
				case ErrorLogSourcesEnum.SqlServer:
				{
					var result = string.Format("Data Source={0};Initial Catalog={1};", connect.Server, connect.Database);
					if (connect.UseIntegratedSecurity)
					{
						result += "Integrated Security=SSPI;";
					}
					else
					{
						result += string.Format("User Id={0};Password={1};", connect.Username, connect.Password);
					}

					return result;
				}

				case ErrorLogSourcesEnum.SqlServerCompact:
					{
						return string.Format("Data Source={0};Persist Security Info=False;", connect.File);
					}

				default:
					throw new InvalidOperationException(string.Format("Error log source {0} is not supported", connect.Source));
			}
		}
	}
}
