using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain
{
	[TestFixture]
	public class AccessErrorLogSourceTests : IntegrationTestBase
	{
		[Test]
		public void GetLogs_SettingsSetToReturnAllLogs_GetsErrorLogsFromDatabase()
		{
			var source = CreateSource(-1);
			var result = source.GetLogs();

			Assert.That(result.Count, Is.EqualTo(4));
		}

		[Test]
		public void GetLogs_SettingsSetToReturnOneLog_GetsErrorLogsFromDatabase()
		{
			var source = CreateSource(1);
			var result = source.GetLogs();

			Assert.That(result.Count, Is.EqualTo(1));
		}
		
		private AccessErrorLogSource CreateSource(int numberOfLogs)
		{
			var settings = new FakeSettingsManager();
			settings.SetMaxNumberOfLogs(numberOfLogs);

			var connectionstring = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;data source={0};", TestAccessDatabase);
			return new AccessErrorLogSource(connectionstring, new ErrorLogFileParser(new FakeLog(), new ClientInformationResolver()), settings, new FakeLog());
		}
	}
}
