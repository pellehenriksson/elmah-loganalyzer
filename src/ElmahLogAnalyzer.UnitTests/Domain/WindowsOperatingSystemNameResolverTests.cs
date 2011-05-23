using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class WindowsOperatingSystemNameResolverTests : UnitTestBase
	{
		[Test]
		public void Resolve_VersionIs95_Returns_Windows95()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows 95"), Is.EqualTo("Windows 95"));
		}

		[Test]
		public void Resolve_VersionIs98_Returns_Windows98()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows 98"), Is.EqualTo("Windows 98"));
		}

		[Test]
		public void Resolve_VersionIsNT40_Returns_WindowsNt4()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows NT 4.0"), Is.EqualTo("Windows NT 4.0"));
		}

		[Test]
		public void Resolve_VersionIsNt50_Returns_Windows2000()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows NT 5.0"), Is.EqualTo("Windows 2000"));
		}

		[Test]
		public void Resolve_VersionIsNt51_Returns_WindowsXp()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows NT 5.1"), Is.EqualTo("Windows XP"));
		}

		[Test]
		public void Resolve_VersionIsNt52_Returns_WindowsServer2003()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows NT 5.2"), Is.EqualTo("Windows Server 2003"));
		}

		[Test]
		public void Resolve_VersionIsNt60_Returns_WindowsVista()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows NT 6.0"), Is.EqualTo("Windows Vista"));
		}

		[Test]
		public void Resolve_VersionIsNt61_Returns_Windows7()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows NT 6.1"), Is.EqualTo("Windows 7"));
		}

		[Test]
		public void Resolve_VersionIsNt62_Returns_Windows8()
		{
			Assert.That(WindowsOperatingSystemNameResolver.Resolve("Windows NT 6.2"), Is.EqualTo("Windows 8"));
		}
	}
}
