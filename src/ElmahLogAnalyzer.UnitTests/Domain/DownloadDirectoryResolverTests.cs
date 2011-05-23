using System;
using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class DownloadDirectoryResolverTests : UnitTestBase
	{
		[Test]
		public void Resolve_TypicalUrl_ShouldBuildDirectoryWithHostnameAndPort()
		{
			// arrange
			var url = new Uri("http://www.test.nu/elmah.axd");

			// assert
			Assert.That(DownloadDirectoryResolver.Resolve(url), Is.EqualTo("www.test.nu_80"));
		}

		[Test]
		public void Resolve_NotPort80_ShouldBuildDirectoryWithHostnameAndPort()
		{
			// arrange
			var url = new Uri("http://www.test.nu:8099/elmah.axd");

			// assert
			Assert.That(DownloadDirectoryResolver.Resolve(url), Is.EqualTo("www.test.nu_8099"));
		}
		
		[Test]
		public void Resolve_Localhost_ShouldBuildDirectoryWithHostnameAndPort()
		{
			// arrange
			var url = new Uri("http://localhost:8099/elmah.axd");

			// assert
			Assert.That(DownloadDirectoryResolver.Resolve(url), Is.EqualTo("localhost_8099"));
		}

		[Test]
		public void Resolve_IpAddress_ShouldBuildDirectoryWithIpAndPort()
		{
			// arrange
			var url = new Uri("http://127.0.0.1:8099/elmah.axd");

			// assert
			Assert.That(DownloadDirectoryResolver.Resolve(url), Is.EqualTo("127.0.0.1_8099"));
		}

		[Test]
		public void Resolve_IsVirtualDirectory_ShouldBuildDirectoryWithHostnameVirtualDirectoryAndPort()
		{
			// arrange
			var url = new Uri("http://localhost:8099/myapp/elmah.axd");

			// assert
			Assert.That(DownloadDirectoryResolver.Resolve(url), Is.EqualTo("localhost_myapp_8099"));
		}

		[Test]
		public void Resolve_IsVirtualDirectoryInMultipleLevels_ShouldBuildDirectoryWithHostnameVirtualDirectoryAndPort()
		{
			// arrange
			var url = new Uri("http://localhost:8099/myapp/somedirectory/elmah.axd");

			// assert
			Assert.That(DownloadDirectoryResolver.Resolve(url), Is.EqualTo("localhost_myapp_somedirectory_8099"));
		}
		
		[Test]
		public void Resolve_IsVirtualDirectoryInMultipleLevelsWithDoubleSlashes_ShouldBuildDirectoryWithHostnameVirtualDirectoryAndPort()
		{
			// arrange
			var url = new Uri("http://localhost:8099//myapp//somedirectory//elmah.axd");

			// assert
			Assert.That(DownloadDirectoryResolver.Resolve(url), Is.EqualTo("localhost_myapp_somedirectory_8099"));
		}
	}
}
