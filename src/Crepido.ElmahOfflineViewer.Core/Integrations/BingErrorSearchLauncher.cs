using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class BingErrorSearchLauncher : ErrorSearchLauncherBase
	{
		private const string UrlTemplate = "http://www.bing.com/search?q={0}+{1}";

		public BingErrorSearchLauncher(ErrorLog errorLog) : base(errorLog)
		{
		}

		public override string BuildSearchUrl()
		{
			return string.Format(UrlTemplate, ErrorLog.Type, ErrorLog.Source);
		}
	}
}
