using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.FileSystem;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLogDownloader : IErrorLogDownloader
	{
		private readonly IWebRequestHelper _webRequst;
		private readonly IFileSystemHelper _fileSystemsHelper;
		private readonly ISettingsManager _settingsManager;
		
		public ErrorLogDownloader(IWebRequestHelper webRequst, IFileSystemHelper fileSystemHelper, ISettingsManager settingsManager)
		{
			_webRequst = webRequst;
			_fileSystemsHelper = fileSystemHelper;
			_settingsManager = settingsManager;
		}

		public Uri ServerUrl { get; private set; }

		public string DownloadDirectory { get; private set; }

		public Dictionary<Uri, DateTime> CsvContent { get; private set; }

		public void Download(Uri url)
		{
			ServerUrl = url;

			ResolveDownloadDirectory();
			CreateDownloadDirectory();
			ResolveLogsAvailableForDownload();

			var logsToDownload = ResolveLogsToDownload();

			foreach (var log in logsToDownload)
			{
				var errorlogXmlDownloadUrl = ResolveErrorLogDownloadUrl(log);
				var errorlogFileName = ResolveErrorLogFileName(errorlogXmlDownloadUrl, log.Value);
				var errorlogFilePath = Path.Combine(DownloadDirectory, errorlogFileName);

				if (ErrorlogAlreadyDownloaded(errorlogFilePath))
				{
					continue;
				}

				var xmlContent = _webRequst.Uri(errorlogXmlDownloadUrl);
				_fileSystemsHelper.CreateTextFile(errorlogFilePath, xmlContent);
			}
		}

		private void ResolveDownloadDirectory()
		{
			var folder = ServerUrl.Host;
			DownloadDirectory = Path.Combine(_fileSystemsHelper.GetCurrentDirectory(), folder);
		}

		private void CreateDownloadDirectory()
		{
			if (!_fileSystemsHelper.DirectoryExists(DownloadDirectory))
			{
				_fileSystemsHelper.CreateDirectory(DownloadDirectory);
			}
		}
		
		private void ResolveLogsAvailableForDownload()
		{
			var csvContent = _webRequst.Uri(ServerUrl);
			var parser = new CsvParser();
			CsvContent = parser.Parse(csvContent);
		}

		private IEnumerable<KeyValuePair<Uri, DateTime>> ResolveLogsToDownload()
		{
			return _settingsManager.GetMaxNumberOfLogs() == -1 ? CsvContent : CsvContent.Take(_settingsManager.GetMaxNumberOfLogs());
		}
		
		private Uri ResolveErrorLogDownloadUrl(KeyValuePair<Uri, DateTime> entry)
		{
			return new Uri(entry.Key.AbsoluteUri.Replace("/details?", "/xml?"));
		}

		private bool ErrorlogAlreadyDownloaded(string path)
		{
			return _fileSystemsHelper.FileExists(path);
		}

		private string ResolveErrorLogFileName(Uri detailsUrl, DateTime time)
		{
			const string template = "error-{0}-{1}.xml";

			var startIndex = detailsUrl.AbsoluteUri.LastIndexOf('=');
			var id = detailsUrl.AbsoluteUri.Substring(startIndex + 1);

			var date = time.ToString().Replace(":", string.Empty).Replace(" ", "-") + "Z";

			return string.Format(template, date, id);
		}
	}
}
