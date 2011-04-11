using Crepido.ElmahOfflineViewer.Core.Common;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Common
{
	[TestFixture]
	public class UrlResolverTests : UnitTestBase
	{
		[Test]
		public void Resolve_WebformsUrl()
		{
			// act
			var result = UrlResolver.Resolve("/seh/entreprenor/pages/Fakturering.aspx");

			// assert
			Assert.That(result, Is.EqualTo("/seh/entreprenor/pages/Fakturering.aspx"));
		}

		[Test]
		public void Resolve_WebformsUrlWithQuerystringParameters()
		{
			// act
			var result = UrlResolver.Resolve("/seh/entreprenor/pages/Fakturering.aspx?someparam=somevalue&someother=someothervalue");

			// assert
			Assert.That(result, Is.EqualTo("/seh/entreprenor/pages/Fakturering.aspx"));
		}
		
		[Test]
		public void Resolve_MvcUrl()
		{
			// act
			var result = UrlResolver.Resolve("/Ruttplan/SkapaValtLappsRad");

			// assert
			Assert.That(result, Is.EqualTo("/Ruttplan/SkapaValtLappsRad"));
		}

		[Test]
		public void Resolve_MvcUrlWithGuidAsIdParameter()
		{
			// act
			var result = UrlResolver.Resolve("/Faktura/HamtaFakturaPdf/92dd2ada-bc26-4e42-b8cf-9eb401249cea");

			// assert
			Assert.That(result, Is.EqualTo("/Faktura/HamtaFakturaPdf"));
		}

		[Test]
		public void Resolve_MvcUrlWithQueryParameters()
		{
			// act
			var result = UrlResolver.Resolve("/Faktura/HamtaFakturaPdf/92dd2ada-bc26-4e42-b8cf-9eb401249cea?displaymode=edit");

			// assert
			Assert.That(result, Is.EqualTo("/Faktura/HamtaFakturaPdf"));
		}

		[Test]
		public void Resolve_MvcRootUrl()
		{
			// act
			var result = UrlResolver.Resolve("/");

			// assert
			Assert.That(result, Is.EqualTo("/"));
		}
	}
}
