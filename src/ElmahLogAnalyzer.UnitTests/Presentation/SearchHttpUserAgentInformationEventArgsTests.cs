using ElmahLogAnalyzer.Core.Presentation;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class SearchHttpUserAgentInformationEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsHttpUserAgentStringAndSearchLauncher()
		{
			// arrange
			const string httpUserAgent = "AdsBot-Google-Mobile (Android; +http://www.google.com/adsbot.html) AppleWebKit";
			const string searchLauncher = "some launcher";

			// act
			var args = new SearchHttpUserAgentInformationEventArgs(httpUserAgent, searchLauncher);

			// assert
			Assert.That(args.HttpUserAgentString, Is.EqualTo(httpUserAgent));
			Assert.That(args.SearchLauncher, Is.EqualTo(searchLauncher));
		}
	}
}
