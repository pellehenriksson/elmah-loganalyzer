using System.IO;
using System.Linq;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.Core.Infrastructure.Web;
using ElmahLogAnalyzer.TestHelpers;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain
{
	[TestFixture]
	public class ErrorLogDownloaderTests : IntegrationTestBase
	{
		[Test][Ignore]
		public void DownloadLogsToLocalDirectory()
		{
			// arrange
			using (var server = new TestWebServer())
			{
				var downloader = new ErrorLogDownloader(new NetworkConnection(TestWebServer.Url), new WebRequestHelper(), new FileSystemHelper(), new CsvParser(), new FakeSettingsManager());

				// act
				downloader.Download();

				// assert
				Assert.That(Directory.Exists(downloader.DownloadDirectory));
				Assert.That(Directory.GetFiles(downloader.DownloadDirectory).Count(), Is.EqualTo(2));
			}
		}
	}
}
