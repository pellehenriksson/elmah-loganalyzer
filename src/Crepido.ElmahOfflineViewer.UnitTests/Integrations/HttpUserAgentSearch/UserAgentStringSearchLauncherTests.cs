using System;
using Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentSearch;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations.HttpUserAgentSearch
{
	[TestFixture]
	public class UserAgentStringSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsProcessHelper()
		{
			// arrange
			var helper = new FakeProcessHelper();

			// act
			var launcher = new UserAgentStringSearchLauncher(helper);

			// assert
			Assert.That(launcher.ProcessHelper, Is.EqualTo(helper));
		}

		[Test]
		public void Launch_BuildUrlAndLaunch()
		{
			// arrange
			var helper = new FakeProcessHelper();
			var launcher = new UserAgentStringSearchLauncher(helper);
			const string httpUserAgent = "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/534.25 (KHTML, like Gecko) Chrome/12.0.706.0 Safari/534.25";

			// act
			launcher.Launch(httpUserAgent);

			// assert
			Console.Out.WriteLine(helper.RunWithUrl);
			Assert.That(helper.RunWithUrl, Is.EqualTo("http://www.useragentstring.com/?uas=Mozilla%2F5.0%20(Windows%20NT%205.1)%20AppleWebKit%2F534.25%20(KHTML%2C%20like%20Gecko)%20Chrome%2F12.0.706.0%20Safari%2F534.25&key=pelHenriGmCom"));
		}
	}
}
