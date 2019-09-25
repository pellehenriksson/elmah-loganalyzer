﻿using System.Net;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Web;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Infrastructure.Web
{
	[TestFixture]
	public class WebRequestHelperTests : IntegrationTestBase
	{
		[Test]
		public void Request_ShouldReturnResponse()
		{
			// arrange
			var helper = new WebRequestHelper();

			// act
			var result = helper.Uri(new NetworkConnection(ExistingUrl));

			// assert
			Assert.That(result.Contains("<title>Google</title>"));
		}

		[Test]
		public void Request_InvalidUrl_Throws()
		{
			// arrange
			var helper = new WebRequestHelper();

			// act
			var result = Assert.Throws<WebException>(() => helper.Uri(new NetworkConnection(NonExistentUrl)));

			// assert
			Assert.That(result, Is.Not.Null);
		}
	}
}
