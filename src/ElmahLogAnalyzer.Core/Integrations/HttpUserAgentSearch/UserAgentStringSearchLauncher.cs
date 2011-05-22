using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch
{
	public class UserAgentStringSearchLauncher : HttpUserAgentSearchLauncherBase, IHttpUserAgentSearchLauncher
	{
		private const string UrlTemplate = "http://www.useragentstring.com/?uas={0}&key=pelHenriGmCom";

		public UserAgentStringSearchLauncher(IUrlNavigationLauncher urlNavigationLauncher) : base(urlNavigationLauncher)
		{
		}
		
		public override string GetUrlTemplate()
		{
			return UrlTemplate;
		}
	}
}
