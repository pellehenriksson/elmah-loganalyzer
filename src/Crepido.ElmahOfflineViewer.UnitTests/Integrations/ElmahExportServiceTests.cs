using System;
using System.IO;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.FileSystem;
using Crepido.ElmahOfflineViewer.Core.Integrations;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations
{
	[TestFixture]
	public class ElmahExportServiceTests : UnitTestBase
	{
		[Test][Ignore("Fix this test, should check for arguments as well")]
		public void Download_StartElmahExp()
		{
			// arrange
			var starter = new FakeProcessStarter();
			var service = new ElmahExportService(new FileSystemHelper(), new FakeSettingsManager(), starter, new FakeLog());
			var url = new Uri("http://localhost:49899/elmah.axd");

			// act
			service.Download(url);

			// assert
			var expected = string.Format("{0} {1}", Path.Combine(Directory.GetCurrentDirectory(), "_ElmahExporter\\elmahexp.exe"), url);
			Assert.That(starter.RunWithUrl, Is.EqualTo(expected));
		}

		[Test]
		public void Download_DownloadSucceeds_ReturnsDownloadDirectory()
		{
			// arrange
			var service = new ElmahExportService(new FileSystemHelper(), new FakeSettingsManager(), new FakeProcessStarter(), new FakeLog());
			var url = new Uri("http://localhost:49899/elmah.axd");

			// act
			var result = service.Download(url);

			// assert
			var expected = Path.Combine(Directory.GetCurrentDirectory(), "_ElmahExporter");
			Assert.That(result, Is.EqualTo(expected));
		}
	}
}
