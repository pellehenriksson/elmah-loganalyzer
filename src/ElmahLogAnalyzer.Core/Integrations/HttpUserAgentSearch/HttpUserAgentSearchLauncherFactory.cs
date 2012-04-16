using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch
{
	public class HttpUserAgentSearchLauncherFactory : IHttpUserAgentSearchLauncherFactory
	{
		public IHttpUserAgentSearchLauncher Create(string searchLauncher)
		{
			if (searchLauncher == "botsvsbrowsers")
			{
				return new BotsVsBrowsersSearchLauncher(new UrlNavigationLauncher());
			}

			return new UserAgentStringSearchLauncher(new UrlNavigationLauncher());
		}
	}
}
