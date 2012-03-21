using ElmahLogAnalyzer.Core.Infrastructure.Dependencies;

namespace ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch
{
	public class HttpUserAgentSearchLauncherFactory : IHttpUserAgentSearchLauncherFactory
	{
		public IHttpUserAgentSearchLauncher Create(string searchLauncher)
		{
			if (searchLauncher == "botsvsbrowsers")
			{
				return ServiceLocator.Resolve<BotsVsBrowsersSearchLauncher>();
			}
			
			return ServiceLocator.Resolve<UserAgentStringSearchLauncher>();
		}
	}
}
