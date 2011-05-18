using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.FileSystem;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.IntegrationTests.Domain
{
	[TestFixture]
	public class ErrorLogDownloaderTests
	{
		[Test][Ignore]
		public void Download()
		{
			var downloader = new ErrorLogDownloader(new WebRequestHelper(), new FileSystemHelper(), new FakeSettingsManager());
			const string url = "http://localhost:49899/elmah.axd/download";
			downloader.Download(url);
		}
	}
}
