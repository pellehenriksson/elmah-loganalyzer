using System.Collections.Generic;
using System.IO;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;

namespace Crepido.ElmahOfflineViewer.IntegrationTests
{
	public static class DatabaseTestDataHelper
	{
		private static readonly FileErrorLogSource Source = new FileErrorLogSource(new ErrorLogFileIncludeOriginalLogParser(new ErrorLogFileParser(new FakeLog())), new FakeSettingsManager(), new FakeLog());
		private static readonly List<ErrorLog> Logs;

		static DatabaseTestDataHelper()
		{
			Logs = Source.GetLogs(Directory.GetCurrentDirectory());
		}

		public static List<ErrorLog> GetLogs()
		{
			return Logs;
		}
	}
}
