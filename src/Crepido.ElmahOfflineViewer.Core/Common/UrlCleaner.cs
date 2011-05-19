using System;

namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public static class UrlCleaner
	{
		private const string WebformsFileExtension = ".aspx";
		
		public static string Clean(string url)
		{
			if (IsRootUrl(url))
			{
				return url;
			}

			if (IsWebformsUrl(url))
			{
				return url;
			}

			if (IsWebformsUrlWithQueryString(url))
			{
				return StripFromQueryParameters(url);
			}

			var lastpart = GetLastPartFromUrl(url);

			if (ContainsQueryString(lastpart))
			{
				return StripLastPart(url);
			}

			return IsGuid(lastpart) ? StripLastPart(url) : url;
		}

		private static bool IsRootUrl(string url)
		{
			return url == "/";
		}

		private static bool IsWebformsUrl(string url)
		{
			return url.EndsWith(WebformsFileExtension);
		}
		
		private static bool IsWebformsUrlWithQueryString(string url)
		{
			return url.Contains(WebformsFileExtension + "?");
		}

		private static string GetLastPartFromUrl(string url)
		{
			var index = url.LastIndexOf("/");
			var lastpart = url.Substring(index + 1);

			return lastpart;
		}

		private static bool ContainsQueryString(string part)
		{
			return part.Contains("?");
		}
		
		private static string StripLastPart(string url)
		{
			var index = url.LastIndexOf("/");
			return url.Substring(0, index);
		}

		private static bool IsGuid(string part)
		{
			Guid id;
			var isGuid = Guid.TryParse(part, out id);
			return isGuid;
		}

		private static string StripFromQueryParameters(string url)
		{
			var index = url.IndexOf(WebformsFileExtension + "?");
			var length = index + WebformsFileExtension.Length;
			var temp = url.Substring(0, length);
			
			return temp;
		}
	}
}
