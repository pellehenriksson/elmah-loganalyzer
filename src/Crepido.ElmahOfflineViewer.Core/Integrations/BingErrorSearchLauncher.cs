using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class BingErrorSearchLauncher : ErrorSearchLauncherBase
	{
		private const string UrlTemplate = "http://www.bing.com/search?q={0}+{1}";

		public BingErrorSearchLauncher(IProcessHelper processHelper) : base(processHelper)
		{
		}

		public override string GetUrlTemplate()
		{
			return UrlTemplate;
		}
	}
}
