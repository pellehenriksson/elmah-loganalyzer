using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class NetworkConnectionTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsUri()
		{
			// arrange
			var url = "http://www.test.com/elmah.axd";

			// act
			var connection = new NetworkConnection(url);

			// assert
			Assert.That(connection.Uri.AbsoluteUri, Is.EqualTo(url));
		}

		[Test]
		public void HasCredentials_CredentialsNotSet_IsFalse()
		{
			// arrange
			var url = "http://www.test.com/elmah.axd";
			var connection = new NetworkConnection(url);

			// act
			var result = connection.HasCredentials;

			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void HasCredentials_CredentialsIsSet_IsTrue()
		{
			// arrange
			var url = "http://www.test.com/elmah.axd";
			var connection = new NetworkConnection(url);

			connection.SetCredentials("pelle", "password", "domain1");

			// act
			var result = connection.HasCredentials;

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void GetCredentials_CredentialsNotSet_ReturnsNull()
		{
			// arrange
			var url = "http://www.test.com/elmah.axd";
			var connection = new NetworkConnection(url);

			// act
			var result = connection.GetCredentials();

			// assert
			Assert.That(result, Is.Null);
		}
		
		[Test]
		public void GetCredentials_CredentialsIsSet_ReturnsCredentials()
		{
			// arrange
			var url = "http://www.test.com/elmah.axd";
			var connection = new NetworkConnection(url);

			connection.SetCredentials("pelle", "password", "domain1");

			// act
			var result = connection.GetCredentials();

			// assert
			Assert.That(result, Is.Not.Null);
		}

		[Test]
		public void GetCredentials_CredentialsIsSet_ShouldHaveUsernamePasswordAndDomain()
		{
			// arrange
			var url = "http://www.test.com/elmah.axd";
			var connection = new NetworkConnection(url);

			connection.SetCredentials("pelle", "password", "domain1");

			// act
			var result = connection.GetCredentials();

			// assert
			Assert.That(result.UserName, Is.EqualTo("pelle"));
			Assert.That(result.Password, Is.EqualTo("password"));
			Assert.That(result.Domain, Is.EqualTo("domain1"));
		}

		[Test]
		public void CreateWithCredentials_CreatesNewConnectionAndCopiesCredentialsFromTheOriginal()
		{
			// arrange
			var url = "http://www.test.com/elmah.axd";
			var original = new NetworkConnection(url);

			original.SetCredentials("pelle", "password", "domain1");

			// act
			var copy = original.CopyWithCredentials("http://www.copy.com/elmah.axd");

			// assert
			Assert.That(copy.Uri.AbsoluteUri, Is.EqualTo("http://www.copy.com/elmah.axd"));
			Assert.That(copy.GetCredentials(), Is.EqualTo(original.GetCredentials()));
		}

		[Test]
		public void IsHttps_UriSchemeIsHttps_IsTrue()
		{
			// arrange
			var url = "https://www.test.com/elmah.axd";
			var connection = new NetworkConnection(url);

			// act
			var result = connection.IsHttps;

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void IsHttps_UriSchemeIsNotHttps_IsFalse()
		{
			// arrange
			var url = "http://www.test.com/elmah.axd";
			var connection = new NetworkConnection(url);

			// act
			var result = connection.IsHttps;

			// assert
			Assert.That(result, Is.False);
		}
	}
}
