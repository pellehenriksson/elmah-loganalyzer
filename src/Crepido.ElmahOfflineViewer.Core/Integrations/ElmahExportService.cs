using System;
using System.IO;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Logging;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class ElmahExportService
	{
		private ISettingsManager _settingsManager;
		private readonly ILog _log;
		private readonly IProcessHelper _processHelper;

		public ElmahExportService(ISettingsManager settingsManager, ILog log, IProcessHelper processHelper)
		{
			_settingsManager = settingsManager;
			_log = log;
			_processHelper = processHelper;
		}
		
		public string Download(string url)
		{
			// path to the schema exp
			var exePath = Path.Combine(Directory.GetCurrentDirectory(), "elmahexp.exe");

			// build download directory from path
			var downloadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "www.someapp.com");

			// call expoter with url number of logs

			// return download directory
			
			// handle all errors from elmahexp.exe)

			try
			{
				_processHelper.Run("");

				return string.Empty;
			}
			catch(Exception ex)
			{
				_log.Error(ex);
				throw;
			}
		}
	}
}
