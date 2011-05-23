using System;
using System.Linq;

namespace ElmahLogAnalyzer.Core.Domain
{
	public static class DownloadDirectoryResolver
	{
		// http://www.webdoubt.com/how-to-get-the-components-of-a-url-in-aspnet/
		public static string Resolve(Uri url)
		{
			var directories = url.Segments
					.Where(IsDirectory)
					.Aggregate(string.Empty, (current, dir) => current + ("_" + dir.Replace("/", string.Empty)));

			return string.Format("{0}{1}_{2}", url.Host, directories, url.Port);
		}

		private static bool IsDirectory(string value)
		{
			return (value != "/") && (value != "elmah.axd");
		}
	}
}
