using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.Core.Integrations.ErrorSearch
{
	public class BingErrorSearchLauncher : ErrorSearchLauncherBase
	{
		private const string UrlTemplate = "http://www.bing.com/search?q={0}+{1}";

		public BingErrorSearchLauncher(IUrlNavigationLauncher urlNavigationLauncher) : base(urlNavigationLauncher)
		{
		}

		public override string GetUrlTemplate()
		{
			return UrlTemplate;
		}
	}
}
