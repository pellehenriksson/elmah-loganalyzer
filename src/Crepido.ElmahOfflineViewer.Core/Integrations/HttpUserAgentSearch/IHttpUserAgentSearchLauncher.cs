using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentSearch
{
	public interface IHttpUserAgentSearchLauncher
	{
		IUrlNavigationLauncher UrlNavigationLauncher { get; }

		void Launch(string httpUserAgentString);
	}
}
