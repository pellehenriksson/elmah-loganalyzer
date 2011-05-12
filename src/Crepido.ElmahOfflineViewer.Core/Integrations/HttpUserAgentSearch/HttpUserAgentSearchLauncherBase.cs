using System;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentSearch
{
	public abstract class HttpUserAgentSearchLauncherBase
	{
		protected HttpUserAgentSearchLauncherBase(IProcessHelper processHelper)
		{
			ProcessHelper = processHelper;
		}

		public IProcessHelper ProcessHelper { get; private set; }

		public void Launch(string httpUserAgentString)
		{
			var url = BuildUrl(httpUserAgentString);
			ProcessHelper.Run(url);
		}

		public abstract string GetUrlTemplate();

		private string BuildUrl(string httpUserAgentString)
		{
			return string.Format(GetUrlTemplate(), Uri.EscapeDataString(httpUserAgentString));
		}
	}
}
