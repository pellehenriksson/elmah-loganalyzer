using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
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
	}
}
