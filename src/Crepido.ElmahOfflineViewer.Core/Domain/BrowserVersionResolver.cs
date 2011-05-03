using System;
using System.Linq;
using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	/// <summary>
	/// Resolves the version of the browser, samples of browser segments are:
	/// MSIE 8.0
	/// Firefox/3.6.16
	/// Chrome/10.0.648.204
	/// Opera 7.23
	/// Safari/533.21.1
	/// </summary>
	public static class BrowserVersionResolver
	{
		public static string Resolve(string browserName, string httpUserAgent)
		{
			if (!httpUserAgent.ContainsText(browserName, true))
			{
				return "UNKNOWN";
			}

			var firstPositionBrowserName = httpUserAgent.LastIndexOf(browserName, StringComparison.InvariantCultureIgnoreCase);

			// position right after browser name
			var firstPositionVersionNumber = firstPositionBrowserName + browserName.Length + 1;
			
			// sub string startign with version number
			var temp = httpUserAgent.Substring(firstPositionVersionNumber);

			// calculate the length of version number
			var versionNumberLength = temp.TakeWhile(c => !c.Equals(' ') && !c.Equals(';')).Count();

			// get version number
			var versionNumber = temp.Substring(0, versionNumberLength);

			return versionNumber;
		}
	}
}
