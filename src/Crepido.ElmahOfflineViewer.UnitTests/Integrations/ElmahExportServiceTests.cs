using Crepido.ElmahOfflineViewer.Core.Integrations;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations
{
	[TestFixture]
	public class ElmahExportServiceTests : UnitTestBase
	{
		[Test]
		public void FirstTest()
		{
			// arrange
			var service = new ElmahExportService(new FakeSettingsManager(), new FakeLog(), new FakeProcessHelper());
			const string url = "http://www.someapp.com/elmah.axd";
			
			// act
			var result = service.Download(url);

			// assert
			Assert.That(result, Is.EqualTo(@"c:\test\www.someapp.com"));
		}
	}
}
