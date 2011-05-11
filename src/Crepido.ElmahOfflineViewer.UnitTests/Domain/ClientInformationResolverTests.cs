using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ClientInformationResolverTests : UnitTestBase
	{
		[Test]
		public void Resolve_HttpUserAgentIsNull_RetunsEmptyClientInformation()
		{
			// arrange
			var resolver = new ClientInformationResolver();

			// act
			var result = resolver.Resolve(null);

			// assert
			Assert.That(result, Is.Not.Null);
		}

		[Test]
		public void Resolve_HttpUserAgentIsEmpty_RetunsEmptyClientInformation()
		{
			// arrange
			var resolver = new ClientInformationResolver();

			// act
			var result = resolver.Resolve(string.Empty);

			// assert
			Assert.That(result, Is.Not.Null);
		}

		[Test]
		public void Resolve_BrowserIsInternetExplorer_ResolvesBrowser()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; Trident/4.0; .NET CLR 1.1.4322; InfoPath.2)";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.Browser, Is.EqualTo("Internet Explorer 8.0"));
		}

		[Test]
		public void Resolve_BrowserIsFirefox_ResolvesBrowser()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.Browser, Is.EqualTo("FireFox 3.6.16"));
		}

		[Test]
		public void Resolve_BrowserIsSafari_ResolvesBrowser()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_7; cs-cz) AppleWebKit/533.21.1 (KHTML, like Gecko) Version/5.0.5 Safari/533.21.1";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.Browser, Is.EqualTo("Safari 533.21.1"));
		}

		[Test]
		public void Resolve_BrowserIsChrome_ResolvesBrowser()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.204 Safari/534.16";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.Browser, Is.EqualTo("Chrome 10.0.648.204"));
		}

		[Test]
		public void Resolve_BrowserIsOpera_ResolvesBrowser()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686) Opera 7.50  [en]";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.Browser, Is.EqualTo("Opera 7.50"));
		}

        [Test]
        public void Resolve_BrowserIsPerl_ResolvesBrowser()
        {
            // arrange
            var resolver = new ClientInformationResolver();
            const string httpUserAgent = "libwww-perl/5.803";

            // act
            var result = resolver.Resolve(httpUserAgent);

            // assert
            Assert.That(result.Browser, Is.EqualTo("UNKNOWN"));
        }
        
        [Test]
		public void Resolve_PlatformIsWindows_ResolvesPlatform()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.Platform, Is.EqualTo("Windows"));
		}

		[Test]
		public void Resolve_PlatformIsMachintosh_ResolvesPlatform()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_7; cs-cz) AppleWebKit/533.21.1 (KHTML, like Gecko) Version/5.0.5 Safari/533.21.1";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.Platform, Is.EqualTo("Macintosh"));
		}

		[Test]
		public void Resolve_PlatformIsLinux_ResolvesPlatform()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686) Opera 7.50  [en]";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.Platform, Is.EqualTo("Linux"));
		}

		[Test]
		public void Resolve_OperatingSystemIsWindowsNT_ResolvesOperatingSystem()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.0; Trident/5.0)";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.OperatingSystem, Is.EqualTo("Windows Vista"));
		}
		
		[Test]
		public void Resolve_OperatingSystemIsMacOsX_ResolvesOperatingSystem()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_7; cs-cz) AppleWebKit/533.21.1 (KHTML, like Gecko) Version/5.0.5 Safari/533.21.1";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.OperatingSystem, Is.EqualTo("Intel Mac OS X 10_6_7"));
		}
		
		[Test]
		public void Resolve_OperatingSystemIsLinux_ResolvesOperatingSystem()
		{
			// arrange
			var resolver = new ClientInformationResolver();
			const string httpUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686) Opera 7.50  [en]";

			// act
			var result = resolver.Resolve(httpUserAgent);

			// assert
			Assert.That(result.OperatingSystem, Is.EqualTo("Linux i686"));
		}
	}
}
