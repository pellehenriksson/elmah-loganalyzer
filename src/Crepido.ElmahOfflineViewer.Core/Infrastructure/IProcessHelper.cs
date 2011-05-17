namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	public interface IProcessHelper
	{
		void Run(string url);

		void Run(string url, string arguments);
	}
}
