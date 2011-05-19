using System;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ElmahUrlHelper
	{
		public Uri ResolveCsvDownloadUrl(Uri serverUrl)
		{
			var downloadUrl = new Uri(serverUrl.AbsoluteUri + ResolveDownloadPart(serverUrl));
			return downloadUrl;
		}

		public Uri ResolveElmahRootUrl(Uri serverUrl)
		{
			if (!serverUrl.AbsoluteUri.EndsWith("elmah.axd"))
			{
				var newUrl = serverUrl.AbsoluteUri + "elmah.axd";
				return new Uri(newUrl);
			}

			return serverUrl;
		}

		private static string ResolveDownloadPart(Uri serverUrl)
		{
			return serverUrl.AbsoluteUri.EndsWith("/") ? "download" : "/download";
		}
	}
}
