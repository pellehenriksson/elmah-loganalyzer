using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentSearch
{
	public class BotsVsBrowsersSearchLauncher : HttpUserAgentSearchLauncherBase, IHttpUserAgentSearchLauncher
	{
		private const string UrlTemplate = "http://www.botsvsbrowsers.com/listings.asp?search={0}";

		public BotsVsBrowsersSearchLauncher(IProcessStarter processStarter) : base(processStarter)
		{
		}
		
		public override string GetUrlTemplate()
		{
			return UrlTemplate;
		}
	}
}
