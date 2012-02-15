using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain
{
	[TestFixture]
	public class SqlServerCompactErrorLogSourceTests : IntegrationTestBase
	{
		[Test]
		public void GetLogs_SettingsSetToReturnAllLogs_GetsErrorLogsFromDatabase()
		{
			var source = CreateSource(-1);
			var result = source.GetLogs();

			Assert.That(result.Count, Is.EqualTo(7));
		}

		[Test]
		public void GetLogs_SettingsSetToReturnOneLog_GetsErrorLogsFromDatabase()
		{
			var source = CreateSource(1);
			var result = source.GetLogs();

			Assert.That(result.Count, Is.EqualTo(1));
		}

		private SqlServerCompactErrorLogSource CreateSource(int numberOfLogs)
		{
			var settings = new FakeSettingsManager();
			settings.SetMaxNumberOfLogs(numberOfLogs);

			var connectionstring = string.Format("data source={0};", TestSqlServerCompactDatabase);
			return new SqlServerCompactErrorLogSource(connectionstring, new ErrorLogFileParser(new FakeLog(), new ClientInformationResolver()), settings, new FakeLog());
		}
	}
}
