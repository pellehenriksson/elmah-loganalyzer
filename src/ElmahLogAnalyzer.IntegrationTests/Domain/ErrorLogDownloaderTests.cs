using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.Core.Infrastructure.Web;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain
{
	[TestFixture]
	public class ErrorLogDownloaderTests
	{
		[Test][Ignore]
		public void Download()
		{
			const string url = "http://localhost:49899/elmah.axd/download";

			var downloader = new ErrorLogDownloader(new NetworkConnection(url), new WebRequestHelper(), new FileSystemHelper(), new CsvParser(), new FakeSettingsManager());
			downloader.Download();
		}
	}
}
