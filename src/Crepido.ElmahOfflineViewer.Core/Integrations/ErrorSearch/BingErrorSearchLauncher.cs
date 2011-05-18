using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.ErrorSearch
{
	public class BingErrorSearchLauncher : ErrorSearchLauncherBase
	{
		private const string UrlTemplate = "http://www.bing.com/search?q={0}+{1}";

		public BingErrorSearchLauncher(IProcessStarter processStarter) : base(processStarter)
		{
		}

		public override string GetUrlTemplate()
		{
			return UrlTemplate;
		}
	}
}
