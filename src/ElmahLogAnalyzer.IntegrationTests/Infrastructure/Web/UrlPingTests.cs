using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Web;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Infrastructure.Web
{
	[TestFixture]
	public class UrlPingTests : IntegrationTestBase
	{
		[Test][Ignore("set up local elmah")]
		public void Ping_ServerRespondedWithOk_ReturnsTrue()
		{
			// arrange
			var helper = new UrlPing();

			// act
			var result = helper.Ping(new NetworkConnection(ExistingUrl));

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void Ping_ServerDoesNotExist_ReturnsFalse()
		{
			// arrange
			var helper = new UrlPing();

			// act
			var result = helper.Ping(new NetworkConnection(NonExistantUrl));

			// assert
			Assert.That(result, Is.False);
		}
	}
}
