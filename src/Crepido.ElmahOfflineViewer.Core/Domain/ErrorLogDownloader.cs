using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.FileSystem;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLogDownloader : IErrorLogDownloader
	{
		private readonly IWebRequestHelper _webRequst;
		private readonly IFileSystemHelper _fileSystemHelper;
		private readonly ICsvParser _csvParser;
		private readonly ISettingsManager _settingsManager;
		
		public ErrorLogDownloader(IWebRequestHelper webRequst, IFileSystemHelper fileSystemHelper, ICsvParser csvParser, ISettingsManager settingsManager)
		{
			_webRequst = webRequst;
			_fileSystemHelper = fileSystemHelper;
			_csvParser = csvParser;
			_settingsManager = settingsManager;
		}
	
		public string DownloadDirectory { get; private set; }

		private Uri ServerUrl { get; set; }
		
		private IEnumerable<KeyValuePair<Uri, DateTime>> CsvContent { get; set; }

		public void Download(Uri url)
		{
			ServerUrl = url;

			ResolveDownloadDirectory();
			CreateDownloadDirectory();
			ResolveLogsAvailableForDownload();

			var entries = ResolveLogsToDownload();

			var webRequst = _webRequst;
			var downloadDirectory = DownloadDirectory;

			var errors = // ...
				from entry in entries 
				let downloadUrl = ResolveErrorLogDownloadUrl(entry)
				let fileName = ResolveErrorLogFileName(downloadUrl, entry.Value)
				let path = Path.Combine(downloadDirectory, fileName)
				where !ErrorlogAlreadyDownloaded(path)
				select new
				{
					FilePath = path,
					Xml = webRequst.Uri(downloadUrl),
				};

			Parallel.ForEach(errors, error => _fileSystemHelper.CreateTextFile(error.FilePath, error.Xml));
		}

		private static Uri ResolveErrorLogDownloadUrl(KeyValuePair<Uri, DateTime> entry)
		{
			return new Uri(entry.Key.AbsoluteUri.Replace("/detail?", "/xml?"));
		}

		private static string ResolveErrorLogFileName(Uri detailsUrl, DateTime time)
		{
			const string template = "error-{0:yyyy'-'MM'-'dd}T{0:HHmmss}Z-{1}.xml";

			var startIndex = detailsUrl.AbsoluteUri.LastIndexOf('=');
			var id = detailsUrl.AbsoluteUri.Substring(startIndex + 1);
			return string.Format(CultureInfo.InvariantCulture, template, time.ToUniversalTime(), id);
		}

		private void ResolveDownloadDirectory()
		{
			var folder = ServerUrl.Host;
			DownloadDirectory = Path.Combine(_fileSystemHelper.GetCurrentDirectory(), folder);
		}

		private void CreateDownloadDirectory()
		{
			if (!_fileSystemHelper.DirectoryExists(DownloadDirectory))
			{
				_fileSystemHelper.CreateDirectory(DownloadDirectory);
			}
		}
		
		private void ResolveLogsAvailableForDownload()
		{
			var downloadUrl = new ElmahUrlHelper().ResolveCsvDownloadUrl(ServerUrl);
			var csvContent = _webRequst.Uri(downloadUrl);
			CsvContent = _csvParser.Parse(csvContent).ToList(/* materialize */);
		}

		private IEnumerable<KeyValuePair<Uri, DateTime>> ResolveLogsToDownload()
		{
			return _settingsManager.GetMaxNumberOfLogs() == -1 ? CsvContent : CsvContent.Take(_settingsManager.GetMaxNumberOfLogs());
		}
		
		private bool ErrorlogAlreadyDownloaded(string path)
		{
			return _fileSystemHelper.FileExists(path);
		}
	}
}
