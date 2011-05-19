using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentSearch
{
	public interface IHttpUserAgentSearchLauncher
	{
		IProcessStarter ProcessStarter { get; }

		void Launch(string httpUserAgentString);
	}
}
