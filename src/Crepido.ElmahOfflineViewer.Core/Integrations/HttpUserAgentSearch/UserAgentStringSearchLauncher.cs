using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentSearch
{
	public class UserAgentStringSearchLauncher : HttpUserAgentSearchLauncherBase, IHttpUserAgentSearchLauncher
	{
		private const string UrlTemplate = "http://www.useragentstring.com/?uas={0}&key=pelHenriGmCom";

		public UserAgentStringSearchLauncher(IProcessStarter processStarter) : base(processStarter)
		{
		}
		
		public override string GetUrlTemplate()
		{
			return UrlTemplate;
		}
	}
}
