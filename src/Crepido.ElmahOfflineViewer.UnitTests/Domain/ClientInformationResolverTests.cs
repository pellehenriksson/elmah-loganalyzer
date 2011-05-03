using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ClientInformationResolverTests : UnitTestBase
	{
		[Test]
		public void Resolve_HttpUserAgenIsNull_Throws()
		{
			// arrange
			var resolver = new ClientInformationResolver();

			// act
			var result = Assert.Throws<ArgumentNullException>(() => resolver.Resolve(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("httpUserAgent"));
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
			Assert.That(result.Browser, Is.EqualTo("Internet Explorer"));
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
			Assert.That(result.Browser, Is.EqualTo("FireFox"));
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
			Assert.That(result.Browser, Is.EqualTo("Safari"));
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
			Assert.That(result.Browser, Is.EqualTo("Chrome"));
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
			Assert.That(result.Browser, Is.EqualTo("Opera"));
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

/*

Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; GTB6.6; .NET CLR 1.1.4322; .NET CLR 2.0.50727; OfficeLiveConnector.1.3; OfficeLivePatch.0.0; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)
Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET4.0C; .NET4.0E)
Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_7; cs-cz) AppleWebKit/533.21.1 (KHTML, like Gecko) Version/5.0.5 Safari/533.21.1
Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; GTB6.6; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)
Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.0; Trident/5.0)
Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.16 (KHTML, like Gecko) Chrome/10.0.648.204 Safari/534.16
Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.16) Gecko/20110319 Firefox/3.6.16
Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 1.1.4322; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)
Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; NetCaptor 7.5.0 Gold; .NET CLR 1.0.3705; .NET CLR 1.1.4322) 
Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; Rogers Hi-Speed Internet; Crazy Browser 1.0.5; .NET CLR 1.0.3705) 
Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2) Opera 7.11 [en] 
Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686) Opera 7.23  [en] 
Mozilla/4.0 (compatible; MSIE 6.0; X11; Linux i686) Opera 7.50  [en] 

*/