using Crepido.ElmahOfflineViewer.Core.Integrations.ErrorSearch;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations.ErrorSearch
{
	[TestFixture]
	public class GoogleErrorSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Launch_BuildUrlAndLaunch()
		{
			// arrange
			var helper = new FakeProcessHelper();
			var launcher = new GoogleErrorSearchLauncher(helper);
			var errorLog = CreateFakeErrorLog();

			// act
			launcher.Launch(errorLog);

			// assert
			Assert.That(helper.RunWithUrl, Is.EqualTo("http://www.google.com/search?q=System.InvalidOperationException+System.Web.Mvc"));
		}
	}
}
