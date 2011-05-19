using System;
using System.Diagnostics;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
	public class UrlNavigationLauncher : IUrlNavigationLauncher
	{
		public void Launch(Uri url)
		{
			Process.Start(url.AbsoluteUri);
		}
	}
}
