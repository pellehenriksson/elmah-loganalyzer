using System;
using System.Diagnostics;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	public class ProcessHelper : IProcessHelper
	{
		public void Run(string url)
		{
			Process.Start(url);
		}

		public void Run(string url, string arguments)
		{
			Process.Start(url, arguments);
		}
	}
}
