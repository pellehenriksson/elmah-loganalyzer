using System.Net;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.IntegrationTests.Infrastructure.Web
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
			var result = helper.Request(ExistingUrl);

			// assert
			Assert.That(result.Contains("<title>Google</title>"));
		}

		[Test]
		public void Request_InvalidUrl_Throws()
		{
			// arrange
			var helper = new WebRequestHelper();

			// act
			var result = Assert.Throws<WebException>(() => helper.Request(NonExistantUrl));

			// assert
			Assert.That(result, Is.Not.Null);
		}
	}
}
