using System;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class ElmahUrlHelper
	{
		public Uri ResolveCsvDownloadUrl(Uri serverUrl)
		{
			var downloadUrl = new Uri(serverUrl.AbsoluteUri + ResolveDownloadPart(serverUrl));
			return downloadUrl;
		}

		public string ResolveElmahRootUrl(string serverUrl)
		{
			if (!serverUrl.Contains("elmah.axd"))
			{
				var newUrl = serverUrl.EndsWith("/") ? serverUrl + "elmah.axd" : serverUrl + "/elmah.axd";
				return newUrl;
			}

			return serverUrl;
		}

		private static string ResolveDownloadPart(Uri serverUrl)
		{
			return serverUrl.AbsoluteUri.EndsWith("/") ? "download" : "/download";
		}
	}
}
