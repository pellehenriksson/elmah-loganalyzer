using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch
{
	public interface IHttpUserAgentSearchLauncher
	{
		IUrlNavigationLauncher UrlNavigationLauncher { get; }

		void Launch(string httpUserAgentString);
	}
}
