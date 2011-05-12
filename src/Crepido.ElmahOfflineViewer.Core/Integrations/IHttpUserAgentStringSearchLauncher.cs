using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public interface IHttpUserAgentStringSearchLauncher
	{
		IProcessHelper ProcessHelper { get; }

		void Launch(string httpUserAgentString);
	}
}
