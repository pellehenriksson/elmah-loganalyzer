using System.Net;
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
			var expected = string.Format("http://www.botsvsbrowsers.com/listings.asp?search={0}", WebUtility.HtmlEncode(httpUserAgent));

			Assert.That(helper.Url, Is.EqualTo(expected));
		}
	}
}
