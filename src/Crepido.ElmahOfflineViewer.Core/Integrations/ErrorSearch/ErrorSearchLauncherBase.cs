using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.ErrorSearch
{
	public abstract class ErrorSearchLauncherBase
	{
		protected ErrorSearchLauncherBase(IUrlNavigationLauncher urlNavigationLauncher)
		{
			UrlNavigationLauncher = urlNavigationLauncher;
		}

		public IUrlNavigationLauncher UrlNavigationLauncher { get; private set; }

		public void Launch(ErrorLog errorLog)
		{
			var url = BuildUrl(errorLog);
			UrlNavigationLauncher.Launch(url);
		}

		public abstract string GetUrlTemplate();

		private Uri BuildUrl(ErrorLog errorLog)
		{
			return new Uri(string.Format(GetUrlTemplate(), Uri.EscapeDataString(errorLog.Type), Uri.EscapeDataString(errorLog.Source)));
		}
	}
}
