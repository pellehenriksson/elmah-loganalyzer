using System;
using Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentSearch;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations.HttpUserAgentSearch
{
	[TestFixture]
	public class BotsVsBrowsersSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsProcessHelper()
		{
			// arrange
			var starter = new FakeProcessStarter();
			
			// act
			var launcher = new BotsVsBrowsersSearchLauncher(starter);

			// assert
			Assert.That(launcher.ProcessStarter, Is.EqualTo(starter));
		}

		[Test]
		public void Launch_BuildUrlAndLaunch()
		{
			// arrange
			var starter = new FakeProcessStarter();
			var launcher = new BotsVsBrowsersSearchLauncher(starter);
			const string httpUserAgent = "AdsBot-Google-Mobile (Android; +http://www.google.com/adsbot.html) AppleWebKit";

			// act
			launcher.Launch(httpUserAgent);

			// assert
			Assert.That(starter.RunWithUrl, Is.EqualTo(new Uri("http://www.botsvsbrowsers.com/listings.asp?search=AdsBot-Google-Mobile%20(Android%3B%20%2Bhttp%3A%2F%2Fwww.google.com%2Fadsbot.html)%20AppleWebKit")));
		}
	}
}
