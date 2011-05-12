using System.Net;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class BotsVsBrowsersSearchLauncher : IHttpUserAgentStringSearchLauncher
	{
		private const string UrlTemplate = "http://www.botsvsbrowsers.com/listings.asp?search={0}";

		public BotsVsBrowsersSearchLauncher(IProcessHelper processHelper)
		{
			ProcessHelper = processHelper;
		}

		public IProcessHelper ProcessHelper { get; private set; }

		public void Launch(string httpUserAgentString)
		{
			var url = BuildSearchUrl(httpUserAgentString);
			ProcessHelper.Start(url);
		}

		private static string BuildSearchUrl(string httpUserAgentString)
		{
			return string.Format(UrlTemplate, WebUtility.HtmlEncode(httpUserAgentString));
		}
	}
}
