using ElmahLogAnalyzer.Core.Presentation;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ConnectToServerEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_ShouldSetUrlUserNamePasswordAndDomain()
		{
			// arrange
			const string url = "http://www.test.com/elmah.axd";
			const string username = "pelle";
			const string password = "password";
			const string domain = "domain1";

			// act
			var args = new ConnectToServerEventArgs(url, username, password, domain);

			// assert
			Assert.That(args.Url, Is.EqualTo(url));
			Assert.That(args.UserName, Is.EqualTo(username));
			Assert.That(args.Password, Is.EqualTo(password));
			Assert.That(args.Domain, Is.EqualTo(domain));
		}

		[Test]
		public void HasCredentials_OnlyUrlHasValue_IsFalse()
		{
			// arrange
			var args = new ConnectToServerEventArgs("http://www.test.com/elmah.axd", string.Empty, null, " ");

			// act
			var result = args.HasCredentials;
			
			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void HasCredentials_UserNameHasValue_IsTrue()
		{
			// arrange
			var args = new ConnectToServerEventArgs("http://www.test.com/elmah.axd", "someuser", string.Empty, string.Empty);

			// act
			var result = args.HasCredentials;

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void HasCredentials_PasswordHasValue_IsTrue()
		{
			// arrange
			var args = new ConnectToServerEventArgs("http://www.test.com/elmah.axd", string.Empty, "password", string.Empty);

			// act
			var result = args.HasCredentials;

			// assert
			Assert.That(result, Is.True);
		}
		
		[Test]
		public void HasCredentials_DomainHasValue_IsTrue()
		{
			// arrange
			var args = new ConnectToServerEventArgs("http://www.test.com/elmah.axd", string.Empty, string.Empty, "domain1");

			// act
			var result = args.HasCredentials;

			// assert
			Assert.That(result, Is.True);
		}
	}
}
