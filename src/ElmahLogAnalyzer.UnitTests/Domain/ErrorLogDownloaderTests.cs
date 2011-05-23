using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;
using ElmahLogAnalyzer.Core.Infrastructure.Web;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class ErrorLogDownloaderTests : UnitTestBase
	{
		private Mock<IWebRequestHelper> _webRequestHelper;
		private Mock<IFileSystemHelper> _fileSystemHelper;
		private Mock<ICsvParser> _csvParser;
		private ISettingsManager _settingsManager;
		
		[SetUp]
		public void Setup()
		{
			_webRequestHelper = new Mock<IWebRequestHelper>();
			_fileSystemHelper = new Mock<IFileSystemHelper>();
			_csvParser = new Mock<ICsvParser>();
			_settingsManager = new FakeSettingsManager();
		}

		[Test]
		public void Download_DowloadDirectoryDoesNotExist_ShouldCreateDownloadDirectoryNamedSameAsUrlHost()
		{
			// arrange
			var downloader = CreateDownloader();
			var connection = new NetworkConnection("http://www.test.com/elmah.axd");

			SetUpDefaultPath();
			_fileSystemHelper.Setup(x => x.DirectoryExists("c:\\test\\www.test.com")).Returns(false);

			// act
			downloader.Download(connection);

			// assert
			_fileSystemHelper.Verify(x => x.CreateDirectory("c:\\test\\www.test.com_80"), Times.Once());
		}

		[Test]
		public void Download_DowloadDirectoryDoesExist_ShouldNotCreateDownloadDirectoryNamedSameAsUrlHost()
		{
			// arrange
			var downloader = CreateDownloader();
			var connection = new NetworkConnection("http://www.test.com/elmah.axd");

			SetUpDefaultPath();
			_fileSystemHelper.Setup(x => x.DirectoryExists("c:\\test\\www.test.com")).Returns(true);

			// act
			downloader.Download(connection);

			// assert
			_fileSystemHelper.Verify(x => x.CreateDirectory("c:\\test\\www.test.com"), Times.Never());
		}

		[Test][Ignore]
		public void Download_ErrorLogIsNotDownloaded_ShouldDownloadErrorLog()
		{
			// arrange

			// act

			// assert
		}

		[Test][Ignore]
		public void Download_ErrorLogAlreadyDownloaded_ShouldNotDownloadErrorLog()
		{
			// arrange

			// act

			// assert
		}
		
		private IErrorLogDownloader CreateDownloader()
		{
			return new ErrorLogDownloader(_webRequestHelper.Object, _fileSystemHelper.Object, _csvParser.Object, _settingsManager);
		}

		private void SetUpDefaultPath()
		{
			var csvContent = new List<KeyValuePair<Uri, DateTime>>();
			csvContent.Add(new KeyValuePair<Uri, DateTime>(new Uri("http://www.test.nu//elmah.axd//detail?id=ee1539b7-7e2a-41a6-a970-d018557b447b"), new DateTime(2011, 5, 14, 12, 30, 10)));
			const string xmlContet = "<xml>somefakecontent</xml>";

			_fileSystemHelper.Setup(x => x.GetCurrentDirectory()).Returns("c:\\test");
			_webRequestHelper.Setup(x => x.Uri(It.IsAny<NetworkConnection>())).Returns(string.Empty);
			_csvParser.Setup(x => x.Parse(It.IsAny<string>())).Returns(csvContent);
			_fileSystemHelper.Setup(x => x.FileExists("error-2011-5-14-123010z-ee1539b7-7e2a-41a6-a970-d018557b447b.xml")).Returns(false);
			_webRequestHelper.Setup(x => x.Uri(It.IsAny<NetworkConnection>())).Returns(xmlContet);
		}
	}
}
