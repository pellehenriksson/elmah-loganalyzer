using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class ClientInformationTests : UnitTestBase
	{
		[Test]
		public void Ctor_HasUnknownPlatform()
		{
			// arrange
			var info = new ClientInformation();

			// assert
			Assert.That(info.Platform, Is.EqualTo("UNKNOWN"));
		}

		[Test]
		public void Ctor_HasUnknownOperatingSystem()
		{
			// arrange
			var info = new ClientInformation();

			// assert
			Assert.That(info.OperatingSystem, Is.EqualTo("UNKNOWN"));
		}

		[Test]
		public void Ctor_HasUnknownBrowser()
		{
			// arrange
			var info = new ClientInformation();

			// assert
			Assert.That(info.Browser, Is.EqualTo("UNKNOWN"));
		}

		[Test]
		public void Ctor_HasEmptyDescription()
		{
			// arrange
			var info = new ClientInformation();
			
			// assert
			Assert.That(info.Description, Is.EqualTo(string.Empty));
		}

		[Test]
		public void Ctor_HasEmptyHttpUserAgentString()
		{
			// arrange
			var info = new ClientInformation();

			// assert
			Assert.That(info.HttpUserAgentString, Is.EqualTo(string.Empty));
		}
	}
}
