using System.Diagnostics;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	public class ProcessHelper : IProcessHelper
	{
		public void Start(string url)
		{
			Process.Start(url);
		}
	}
}
