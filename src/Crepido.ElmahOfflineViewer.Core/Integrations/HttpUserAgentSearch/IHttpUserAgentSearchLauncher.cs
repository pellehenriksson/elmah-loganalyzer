using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentSearch
{
	public interface IHttpUserAgentSearchLauncher
	{
		IProcessHelper ProcessHelper { get; }

		void Launch(string httpUserAgentString);
	}
}
