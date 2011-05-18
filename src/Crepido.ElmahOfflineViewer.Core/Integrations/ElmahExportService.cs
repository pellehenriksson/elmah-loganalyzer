using System;
using System.IO;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.FileSystem;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Logging;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class ElmahExportService
	{
		private readonly IFileSystemHelper _fileSystemHelper;
		private readonly ISettingsManager _settingsManager;
		private readonly ILog _log;
		private readonly IProcessStarter _processStarter;

		public ElmahExportService(IFileSystemHelper fileSystemHelper, ISettingsManager settingsManager, IProcessStarter processStarter, ILog log)
		{
			_fileSystemHelper = fileSystemHelper;
			_settingsManager = settingsManager;
			_log = log;
			_processStarter = processStarter;
		}
		
		public string Download(Uri url)
		{
			var exporterPath = Path.Combine(_fileSystemHelper.GetCurrentDirectory(), "_ElmahExporter\\elmahexp.exe");

			if (!_fileSystemHelper.FileExists(exporterPath))
			{
				Console.Out.WriteLine("Failed to find the path " + exporterPath);
			}

			var downloadDirectory = Path.GetDirectoryName(exporterPath);

			try
			{
				var arguments = string.Format("\"{0}\" \"--trace\" \"--output-dir\" \"{1}\"", url, downloadDirectory);
				_processStarter.Run(exporterPath, arguments);

				return downloadDirectory;
			}
			catch (Exception ex)
			{
				_log.Error(ex);
				throw;
			}
		}
	}
}
