using System;
using System.Diagnostics;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public abstract class ErrorSearchLauncherBase
	{
		protected ErrorSearchLauncherBase(ErrorLog errorLog)
		{
			if (errorLog == null)
			{
				throw new ArgumentNullException("errorLog");	
			}

			ErrorLog = errorLog;
		}
		
		public ErrorLog ErrorLog { get; private set; }
		
		public void Launch()
		{
			var url = BuildSearchUrl();
			Process.Start(url);
		}

		public abstract string BuildSearchUrl();
	}
}
