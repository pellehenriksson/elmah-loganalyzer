namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	public interface IProcessStarter
	{
		void Run(string url);

		void Run(string url, string arguments);
	}
}
