using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.ErrorSearch
{
	public abstract class ErrorSearchLauncherBase
	{
		protected ErrorSearchLauncherBase(IProcessHelper processHelper)
		{
			ProcessHelper = processHelper;
		}

		public IProcessHelper ProcessHelper { get; private set; }

		public void Launch(ErrorLog errorLog)
		{
			var url = BuildUrl(errorLog);
			ProcessHelper.Run(url);
		}

		public abstract string GetUrlTemplate();

		private string BuildUrl(ErrorLog errorLog)
		{
			return string.Format(GetUrlTemplate(), Uri.EscapeDataString(errorLog.Type), Uri.EscapeDataString(errorLog.Source));
		}
	}
}
