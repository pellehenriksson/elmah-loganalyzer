using System;
using System.Diagnostics;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	public class ProcessStarter : IProcessStarter
	{
		public void Run(Uri url)
		{
			Process.Start(url.AbsoluteUri);
		}

		public void Run(Uri url, string arguments)
		{
			Process.Start(url.AbsoluteUri, arguments);
		}
	}
}
