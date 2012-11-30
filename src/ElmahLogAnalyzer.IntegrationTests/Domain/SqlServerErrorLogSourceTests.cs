using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain
{
	[TestFixture]
	public class SqlServerErrorLogSourceTests 
	{
		[Test]
		public void GetLogs_SettingsSetToReturnAllLogs_GetsErrorLogsFromDatabase()
		{
			var source = CreateSource(-1);
			var result = source.GetLogs();

			Assert.That(result.Count, Is.EqualTo(9));
		}

		[Test]
		public void GetLogs_SettingsSetToReturnOneLog_GetsErrorLogsFromDatabase()
		{
			var source = CreateSource(1);
			var result = source.GetLogs();

			Assert.That(result.Count, Is.EqualTo(1));
		}

		[Test]
		public void GetLogs_InitializedWithCustomSchema()
		{
			var source = CreateSourceWithCustomSchema(1);
			var result = source.GetLogs();

			Assert.That(result.Count, Is.EqualTo(1));
		}
		
		private static SqlServerErrorLogSource CreateSource(int numberOfLogs)
		{
			var settings = new FakeSettingsManager();
			settings.SetMaxNumberOfLogs(numberOfLogs);

			return new SqlServerErrorLogSource(@"data source=.\SQLEXPRESS;Initial Catalog=ElmahLogAnalyzer;Integrated Security=SSPI", null, null, new ErrorLogFileParser(new FakeLog(), new ClientInformationResolver()), settings, new FakeLog());
		}

		private static SqlServerErrorLogSource CreateSourceWithCustomSchema(int numberOfLogs)
		{
			var settings = new FakeSettingsManager();
			settings.SetMaxNumberOfLogs(numberOfLogs);

			return new SqlServerErrorLogSource(@"data source=.\SQLEXPRESS;Initial Catalog=ElmahLogAnalyzer;Integrated Security=SSPI", "dbo", null, new ErrorLogFileParser(new FakeLog(), new ClientInformationResolver()), settings, new FakeLog());
		}
	}
}
