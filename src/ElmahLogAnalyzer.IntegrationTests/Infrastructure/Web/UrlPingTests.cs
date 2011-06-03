using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Web;
using ElmahLogAnalyzer.TestHelpers.Fakes;
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
			var helper = new UrlPing(new FakeLog());

			// act
			var result = helper.Ping(new NetworkConnection(ExistingUrl));

			// assert
			Assert.That(result.Item1, Is.True);
		}

		[Test]
		public void Ping_ServerDoesNotExist_ReturnsFalse()
		{
			// arrange
			var helper = new UrlPing(new FakeLog());

			// act
			var result = helper.Ping(new NetworkConnection(NonExistantUrl));

			// assert
			Assert.That(result.Item1, Is.False);
			Assert.That(result.Item2, Is.EqualTo("The remote name could not be resolved: 'www.bluttanblä.com'"));
		}
	}
}
