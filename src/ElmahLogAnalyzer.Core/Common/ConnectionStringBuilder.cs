using System;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.Core.Common
{
	public static class ConnectionStringBuilder
	{
		public static string Build(IConnectToDatabase connect)
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

				default:
					throw new InvalidOperationException(string.Format("Database type: {0} is not supported", connect.Source));
			}
		}
	}
}
