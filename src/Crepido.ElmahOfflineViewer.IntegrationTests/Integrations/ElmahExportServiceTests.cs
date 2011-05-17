using System;
using System.IO;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using Crepido.ElmahOfflineViewer.Core.Integrations;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.IntegrationTests.Integrations
{
	[TestFixture]
	public class ElmahExportServiceTests
	{
		[Test][Ignore]
		public void Download_DownloadSucceeds_ReturnsDownloadDirectory()
		{
			// arrange
			var service = new ElmahExportService(new FakeSettingsManager(), new FakeLog(), new ProcessHelper());
			var url = new Uri("http://localhost:51046/elmah.axd");

			// act
			var result = service.Download(url);

			// assert
			var expected = Path.Combine(Directory.GetCurrentDirectory(), "_ElmahExporter");
			Assert.That(result, Is.EqualTo(expected));
		}
	}
}
