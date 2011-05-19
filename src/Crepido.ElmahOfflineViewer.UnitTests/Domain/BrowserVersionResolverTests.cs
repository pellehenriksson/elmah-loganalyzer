using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class BrowserVersionResolverTests : UnitTestBase
	{
		[Test]
		public void Resolve_BrowserIsInternetExplorer_ResolveVersion()
		{
			// arrange
			const string httpUserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; Trident/4.0; .NET CLR 1.1.4322; InfoPath.2)";

			// assert
			Assert.That(BrowserVersionResolver.Resolve("MSIE", httpUserAgent), Is.EqualTo("8.0"));
		}

		[Test]
		public void Resolve_BrowserIsChrome_ResolveVersion()
		{
			// arrange
			const string httpUserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.204 Safari/534.16";

			// assert
			Assert.That(BrowserVersionResolver.Resolve("Chrome", httpUserAgent), Is.EqualTo("10.0.648.204"));
		}

		[Test]
		public void Resolve_BrowserIsSafari_ResolveVersion()
		{
			// arrange
			const string httpUserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_7; cs-cz) AppleWebKit/533.21.1 (KHTML, like Gecko) Version/5.0.5 Safari/533.21.1";

			// assert
			Assert.That(BrowserVersionResolver.Resolve("Safari", httpUserAgent), Is.EqualTo("533.21.1"));
		}
		
		[Test]
		public void Resolve_BrowserIsFirefox_ResolveVersion()
		{
			// arrange
			const string httpUserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16";

			// assert
			Assert.That(BrowserVersionResolver.Resolve("Firefox", httpUserAgent), Is.EqualTo("3.6.16"));
		}

		[Test]
		public void Resolve_BrowserIsOpera_ResolveVersion()
		{
			// arrange
			const string httpUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686) Opera 7.50  [en]";

			// assert
			Assert.That(BrowserVersionResolver.Resolve("Opera", httpUserAgent), Is.EqualTo("7.50"));
		}
		
		[Test]
		public void Resolve_BrowserNotFound_VersionIsUnknown()
		{
			// arrange
			const string httpUserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; Trident/4.0; .NET CLR 1.1.4322; InfoPath.2)";

			// assert
			Assert.That(BrowserVersionResolver.Resolve("Netscape", httpUserAgent), Is.EqualTo("UNKNOWN"));
		}
	}
}
