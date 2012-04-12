using System;
using System.Collections.Generic;
using System.Linq;
using ElmahLogAnalyzer.Core.Common;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
	[TestFixture]
	public class UrlCleanerTests : UnitTestBase
	{
		[Test]
		public void Clean_WebformsUrl()
		{
			// act
			var result = UrlCleaner.Clean("/seh/entreprenor/pages/Fakturering.aspx");

			// assert
			Assert.That(result, Is.EqualTo("/seh/entreprenor/pages/Fakturering.aspx"));
		}

		[Test]
		public void Clean_WebformsUrlWithQuerystringParameters()
		{
			// act
			var result = UrlCleaner.Clean("/seh/entreprenor/pages/Fakturering.aspx?someparam=somevalue&someother=someothervalue");

			// assert
			Assert.That(result, Is.EqualTo("/seh/entreprenor/pages/Fakturering.aspx"));
		}
		
		[Test]
		public void Clean_MvcUrl()
		{
			// act
			var result = UrlCleaner.Clean("/Ruttplan/SkapaValtLappsRad");

			// assert
			Assert.That(result, Is.EqualTo("/Ruttplan/SkapaValtLappsRad"));
		}

		[Test]
		public void Clean_MvcUrlWithGuidAsIdParameter()
		{
			// act
			var result = UrlCleaner.Clean("/Faktura/HamtaFakturaPdf/92dd2ada-bc26-4e42-b8cf-9eb401249cea");

			// assert
			Assert.That(result, Is.EqualTo("/Faktura/HamtaFakturaPdf"));
		}

		[Test]
		public void Clean_MvcUrlWithQueryParameters()
		{
			// act
			var result = UrlCleaner.Clean("/Faktura/HamtaFakturaPdf/92dd2ada-bc26-4e42-b8cf-9eb401249cea?displaymode=edit");

			// assert
			Assert.That(result, Is.EqualTo("/Faktura/HamtaFakturaPdf"));
		}

		[Test]
		public void Clean_MvcRootUrl()
		{
			// act
			var result = UrlCleaner.Clean("/");

			// assert
			Assert.That(result, Is.EqualTo("/"));
		}
	}
}
