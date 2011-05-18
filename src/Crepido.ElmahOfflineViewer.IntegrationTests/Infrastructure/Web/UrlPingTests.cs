using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.IntegrationTests.Infrastructure.Web
{
	[TestFixture]
	public class UrlPingTests : IntegrationTestBase
	{
		[Test]
		public void Ping_ServerRespondedWithOk_ReturnsTrue()
		{
			// arrange
			var helper = new UrlPing();

			// act
			var result = helper.Ping(ExistingUrl);

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void Ping_ServerDoesNotExist_ReturnsFalse()
		{
			// arrange
			var helper = new UrlPing();

			// act
			var result = helper.Ping(NonExistantUrl);

			// assert
			Assert.That(result, Is.False);
		}
	}
}
