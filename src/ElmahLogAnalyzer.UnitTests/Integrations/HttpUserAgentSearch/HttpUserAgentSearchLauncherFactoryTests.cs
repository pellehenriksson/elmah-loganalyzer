using ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Integrations.HttpUserAgentSearch
{
	[TestFixture]
	public class HttpUserAgentSearchLauncherFactoryTests : UnitTestBase
	{
		[Test]
		public void Create_SourceIsBotsVsBrowsers_LauncherIsBotsVsBrowsersSearchLauncher()
		{
			// arrange
			var factory = new HttpUserAgentSearchLauncherFactory();

			// act
			var result = factory.Create("botsvsbrowsers");

			// assert
			Assert.That(result, Is.InstanceOf<BotsVsBrowsersSearchLauncher>());
		}

		[Test]
		public void Create_SourceIsEmpty_LauncherIsUserAgentStringSearchLauncher()
		{
			// arrange
			var factory = new HttpUserAgentSearchLauncherFactory();

			// act
			var result = factory.Create(string.Empty);

			// assert
			Assert.That(result, Is.InstanceOf<UserAgentStringSearchLauncher>());
		}
	}
}
