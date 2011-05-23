using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch
{
	public class BotsVsBrowsersSearchLauncher : HttpUserAgentSearchLauncherBase, IHttpUserAgentSearchLauncher
	{
		private const string UrlTemplate = "http://www.botsvsbrowsers.com/listings.asp?search={0}";

		public BotsVsBrowsersSearchLauncher(IUrlNavigationLauncher urlNavigationLauncher) : base(urlNavigationLauncher)
		{
		}
		
		public override string GetUrlTemplate()
		{
			return UrlTemplate;
		}
	}
}
