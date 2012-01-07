using ElmahLogAnalyzer.Core.Infrastructure.Configuration;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Infrastructure.Configuration
{
	[TestFixture]
	public class WebServerConnectionsHelperTests
	{
		[Test]
		public void GetSettings_ReadsConfiguration()
		{
			// arrange
			var helper = new WebServerConnectionsHelper();

			// act
			var result = helper.GetConnections();

			// assert
			Assert.That(result.Count, Is.EqualTo(2));
		}

		[Test]
		public void GetSettings_SettingsHaveCorrectValues()
		{
			// arrange
			var helper = new WebServerConnectionsHelper();

			// act
			var result = helper.GetConnections();

			// assert
			var setting = result[0];

			Assert.That(setting.Url, Is.EqualTo("http://localhost:1234/elmah.axd"));
			Assert.That(setting.Username, Is.EqualTo(string.Empty));
			Assert.That(setting.Password, Is.EqualTo(string.Empty));
			Assert.That(setting.Domain, Is.EqualTo(string.Empty));

			setting = result[1];

			Assert.That(setting.Url, Is.EqualTo("http://production/someapp/elmah.axd"));
			Assert.That(setting.Username, Is.EqualTo("pelle"));
			Assert.That(setting.Password, Is.EqualTo("secret"));
			Assert.That(setting.Domain, Is.EqualTo("mydomain"));
		}

		[Test]
		public void GetUrls_ReturnsListOfUrls()
		{
			// arrange
			var helper = new WebServerConnectionsHelper();

			// act
			var result = helper.GetUrls();

			// assert
			Assert.AreEqual(result[0], "http://localhost:1234/elmah.axd");
			Assert.AreEqual(result[1], "http://production/someapp/elmah.axd");
		}

		[Test]
		public void FindConfiguration_UrlFound_ReturnsConfiguration()
		{
			// arrange
			var helper = new WebServerConnectionsHelper();

			// act
			var result = helper.FindConnection("http://production/someapp/elmah.axd");

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.Username, Is.EqualTo("pelle"));
			Assert.That(result.Password, Is.EqualTo("secret"));
			Assert.That(result.Domain, Is.EqualTo("mydomain"));
		}
		
		[Test]
		public void FindConfiguration_UrlNotFound_ReturnsNull()
		{
			// arrange
			var helper = new WebServerConnectionsHelper();

			// act
			var result = helper.FindConnection(string.Empty);

			// assert
			Assert.That(result, Is.Null);
		}
	}
}
