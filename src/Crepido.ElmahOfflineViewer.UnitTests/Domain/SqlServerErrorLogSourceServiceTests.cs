using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class SqlServerErrorLogSourceServiceTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsPath()
		{
			// arrange
			var log = new FakeLog();
			var parser = new ErrorLogFileParser(log);
			const string path = @"Data Source=.\sqlexpress;Initial Catalog=ElmahOfflineViewer;Integrated Security=SSPI;";

			// act
			var source = new SqlServerErrorLogSource(parser, new FakeSettingsManager(), log, path);

			// assert
			Assert.That(source.Path, Is.EqualTo(path));
		}
	}
}
