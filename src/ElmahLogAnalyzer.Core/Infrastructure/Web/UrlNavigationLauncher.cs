using System;
using System.Diagnostics;

namespace ElmahLogAnalyzer.Core.Infrastructure.Web
{
	public class UrlNavigationLauncher : IUrlNavigationLauncher
	{
		public void Launch(Uri url)
		{
			Process.Start(url.AbsoluteUri);
		}
	}
}
