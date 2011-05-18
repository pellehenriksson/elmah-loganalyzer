using Crepido.ElmahOfflineViewer.Core.Integrations.ErrorSearch;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations.ErrorSearch
{
	[TestFixture]
	public class BingErrorSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Launch_BuildUrlAndLaunch()
		{
			// arrange
			var starter = new FakeProcessStarter();
			var launcher = new BingErrorSearchLauncher(starter);
			var errorLog = CreateFakeErrorLog();
			
			// act
			launcher.Launch(errorLog);

			// assert
			Assert.That(starter.RunWithUrl, Is.EqualTo("http://www.bing.com/search?q=System.InvalidOperationException+System.Web.Mvc"));
		}
	}
}
