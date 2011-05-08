using System;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class GoogleErrorSearchLauncher : IErrorWebSearchLauncher
	{
		public void Search(ErrorLog errorLog)
		{
			if (errorLog == null)
			{
				throw new ArgumentNullException("errorLog");
			}
		}
	}
}
