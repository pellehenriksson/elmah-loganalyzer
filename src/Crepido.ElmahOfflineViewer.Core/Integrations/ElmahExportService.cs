using System;
using System.IO;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Logging;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class ElmahExportService
	{
		private readonly ISettingsManager _settingsManager;
		private readonly ILog _log;
		private readonly IProcessHelper _processHelper;

		public ElmahExportService(ISettingsManager settingsManager, ILog log, IProcessHelper processHelper)
		{
			_settingsManager = settingsManager;
			_log = log;
			_processHelper = processHelper;
		}
		
		public string Download(Uri url)
		{
			var exporterPath = Path.Combine(Directory.GetCurrentDirectory(), "_ElmahExporter\\elmahexp.exe");

			if (!File.Exists(exporterPath))
			{
				Console.Out.WriteLine("Failed to find the path " + exporterPath);
			}

			var downloadDirectory = Path.GetDirectoryName(exporterPath);

			try
			{
				var arguments = string.Format("\"{0}\" \"--trace\" \"--output-dir\" \"{1}\"", url, downloadDirectory);
				_processHelper.Run(exporterPath, arguments);

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
