using System;
using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch
{
	public abstract class HttpUserAgentSearchLauncherBase
	{
		protected HttpUserAgentSearchLauncherBase(IUrlNavigationLauncher urlNavigationLauncher)
		{
			UrlNavigationLauncher = urlNavigationLauncher;
		}

		public IUrlNavigationLauncher UrlNavigationLauncher { get; private set; }

		public void Launch(string httpUserAgentString)
		{
			var url = BuildUrl(httpUserAgentString);
			UrlNavigationLauncher.Launch(url);
		}

		public abstract string GetUrlTemplate();

		private Uri BuildUrl(string httpUserAgentString)
		{
			return new Uri(string.Format(GetUrlTemplate(), Uri.EscapeDataString(httpUserAgentString)));
		}
	}
}
