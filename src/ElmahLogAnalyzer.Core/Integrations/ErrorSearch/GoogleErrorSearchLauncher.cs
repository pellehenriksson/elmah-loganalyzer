using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.Core.Integrations.ErrorSearch
{
	public class GoogleErrorSearchLauncher : ErrorSearchLauncherBase
	{
		private const string UrlTemplate = "http://www.google.com/search?q={0}+{1}";

		public GoogleErrorSearchLauncher(IUrlNavigationLauncher urlNavigationLauncher) : base(urlNavigationLauncher)
		{
		}

		public override string GetUrlTemplate()
		{
			return UrlTemplate;
		}
	}
}
