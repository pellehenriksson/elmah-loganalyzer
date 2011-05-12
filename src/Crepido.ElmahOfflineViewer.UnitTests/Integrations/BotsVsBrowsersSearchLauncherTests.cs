using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations
{
	[TestFixture]
	public class BotsVsBrowsersSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsProcessHelper()
		{
			// arrange
			var helper = new FakeProcessHelper();
			
			// act
			var launcher = new Core.Integrations.BotsVsBrowsersSearchLauncher(helper);

			// assert
			Assert.That(launcher.ProcessHelper, Is.EqualTo(helper));
		}

		[Test]
		public void Launch_BuildUrlAndLaunch()
		{
			// arrange
			var helper = new FakeProcessHelper();
			var launcher = new Core.Integrations.BotsVsBrowsersSearchLauncher(helper);
			const string httpUserAgent = "AdsBot-Google-Mobile (Android; +http://www.google.com/adsbot.html) AppleWebKit";

			// act
			launcher.Launch(httpUserAgent);

			// assert
			Assert.That(helper.Url, Is.EqualTo("http://www.botsvsbrowsers.com/listings.asp?search=AdsBot-Google-Mobile%20(Android%3B%20%2Bhttp%3A%2F%2Fwww.google.com%2Fadsbot.html)%20AppleWebKit"));
		}
	}
}
