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

		private static string ResolveDownloadPart(Uri serverUrl)
		{
			return serverUrl.AbsoluteUri.EndsWith("/") ? "download" : "/download";
		}
	}
}
