using System.Configuration;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.IntegrationTests.Domain
{
	[TestFixture]
	public class SqlServerErrorLogSourceTests
	{
		private static readonly string Path = ConfigurationManager.ConnectionStrings["MsSqlServer"].ConnectionString;

		[TestFixtureSetUp]
		public void FixtureSetup()
		{
			DatabaseHelper.BuildDatabase(Path);
		}

		[Test]
		public void FakeTest()
		{
			// arrange
			var source = new SqlServerErrorLogSource(new ErrorLogFileParser(new FakeLog()), new SettingsManager(), new FakeLog(), Path);

			// act
			var result = source.GetLogs(Path);

			// assert
			Assert.That(result.Count, Is.EqualTo(20));
		}
	}
}
