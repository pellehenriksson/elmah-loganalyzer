using System;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Common
{
	public static class ConnectionInformationHelper
	{
		public static string GetInformation(ErrorLogSources source, string connection)
		{
			switch (source)
			{
				case ErrorLogSources.Files:
					return string.Format("Connected to directory: {0}", connection);
				case ErrorLogSources.SqlServer:
					return string.Format("Connected to {0}: {1}", source.GetDescription(), SqlServerConnectionInformation(connection));
				case ErrorLogSources.SqlServerCompact:
					return string.Format("Connected to {0}: {1}", source.GetDescription(), SplitConnectionString(connection)[0]);
				case ErrorLogSources.Access:
					return string.Format("Connected to {0}: {1}", source.GetDescription(), SplitConnectionString(connection)[1]);
			}

			throw new NotImplementedException();
		}

		private static string SqlServerConnectionInformation(string connection)
		{
			var items = SplitConnectionString(connection);
			return string.Format("{0} {1}", items[0], items[1]);
		}

		private static string[] SplitConnectionString(string connection)
		{
			return connection.Split(';');
		}
	}
}
