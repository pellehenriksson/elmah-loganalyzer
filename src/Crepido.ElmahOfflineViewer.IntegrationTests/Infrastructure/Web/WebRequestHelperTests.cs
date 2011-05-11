using System.Net;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.IntegrationTests.Infrastructure.Web
{
	[TestFixture]
	public class WebRequestHelperTests
	{
		[Test]
		public void Request_ShouldReturnResponse()
		{
			// arrange
			var helper = new WebRequestHelper();
			const string url = "http://www.google.com";

			// act
			var result = helper.Request(url);

			// assert
			Assert.That(result.Contains("<title>Google</title>"));
		}

		[Test]
		public void Request_InvalidUrl_Throws()
		{
			// arrange
			var helper = new WebRequestHelper();
			const string url = "http://www.bluttanblä.com";

			// act
			var result = Assert.Throws<WebException>(() => helper.Request(url));

			// assert
			Assert.That(result, Is.Not.Null);
		}
	}
}
