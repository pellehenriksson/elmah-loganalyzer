using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.ErrorSearch
{
	public abstract class ErrorSearchLauncherBase
	{
		protected ErrorSearchLauncherBase(IProcessStarter processStarter)
		{
			ProcessStarter = processStarter;
		}

		public IProcessStarter ProcessStarter { get; private set; }

		public void Launch(ErrorLog errorLog)
		{
			var url = BuildUrl(errorLog);
			ProcessStarter.Run(url);
		}

		public abstract string GetUrlTemplate();

		private Uri BuildUrl(ErrorLog errorLog)
		{
			return new Uri(string.Format(GetUrlTemplate(), Uri.EscapeDataString(errorLog.Type), Uri.EscapeDataString(errorLog.Source)));
		}
	}
}
