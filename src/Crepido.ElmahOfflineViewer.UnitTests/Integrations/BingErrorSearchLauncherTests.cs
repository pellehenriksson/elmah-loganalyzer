using Crepido.ElmahOfflineViewer.Core.Integrations;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations
{
	[TestFixture]
	public class BingErrorSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Launch_BuildUrlAndLaunch()
		{
			// arrange
			var helper = new FakeProcessHelper();
			var launcher = new BingErrorSearchLauncher(helper);
			var errorLog = CreateFakeErrorLog();
			
			// act
			launcher.Launch(errorLog);

			// assert
			Assert.That(helper.RunWithUrl, Is.EqualTo("http://www.bing.com/search?q=System.InvalidOperationException+System.Web.Mvc"));
		}
	}
}
