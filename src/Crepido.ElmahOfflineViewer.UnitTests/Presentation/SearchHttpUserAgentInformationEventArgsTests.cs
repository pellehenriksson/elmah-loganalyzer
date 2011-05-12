using Crepido.ElmahOfflineViewer.Core.Presentation;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Presentation
{
	[TestFixture]
	public class SearchHttpUserAgentInformationEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsHttpUserAgentString()
		{
			// arrange
			const string httpUserAgent = "AdsBot-Google-Mobile (Android; +http://www.google.com/adsbot.html) AppleWebKit";

			// act
			var args = new SearchHttpUserAgentInformationEventArgs(httpUserAgent);

			// assert
			Assert.That(args.HttpUserAgentString, Is.EqualTo(httpUserAgent));
		}
	}
}
