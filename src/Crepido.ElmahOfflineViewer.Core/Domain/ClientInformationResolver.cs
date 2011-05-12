using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ClientInformationResolver : IClientInformationResolver
	{
		private string _httpUserAgent;
		private string _parenthesisSegment;
		private string[] _parenthesisSegmentValues;
		private string _lastSegment;

		public ClientInformation Resolve(string httpUserAgent)
		{
			if (!httpUserAgent.HasValue())
			{
				return new ClientInformation();
			}

			_httpUserAgent = httpUserAgent;

			SplitHttpUserAgent(httpUserAgent);

			var information = new ClientInformation
			                  	{
			                  		Browser = ResolveBrowser(),
			                  		Platform = ResolvePlatform(),
			                  		OperatingSystem = ResolveOperatingSystem(),
			                  		HttpUserAgentString = _httpUserAgent
			                  	};

			return information;
		}

		private void SplitHttpUserAgent(string httpUserAgent)
		{
			var leftParenthesisIndex = _httpUserAgent.IndexOf('(');
			var rightParenthesisIndex = _httpUserAgent.IndexOf(')');

            var hasParenthesizedSegment = leftParenthesisIndex >= 0 && rightParenthesisIndex > leftParenthesisIndex;

            var parenthesisSegmentLength = rightParenthesisIndex - leftParenthesisIndex;
            _parenthesisSegment = hasParenthesizedSegment 
                                ? httpUserAgent.Substring(leftParenthesisIndex, parenthesisSegmentLength)
                                : string.Empty;

            _parenthesisSegmentValues = _parenthesisSegment.Split(';');

            _lastSegment = hasParenthesizedSegment
                         ? httpUserAgent.Substring(rightParenthesisIndex)
                         : httpUserAgent;
		}

		private string ResolveBrowser()
		{
			if (_lastSegment.ContainsText(Constants.Browsers.Chrome, true))
			{
				var version = BrowserVersionResolver.Resolve(Constants.Browsers.Chrome, _httpUserAgent);
				return string.Format("{0} {1}", Constants.Browsers.Chrome, version);
			}

			if (_lastSegment.ContainsText(Constants.Browsers.FireFox, true))
			{
				var version = BrowserVersionResolver.Resolve(Constants.Browsers.FireFox, _httpUserAgent);
				return string.Format("{0} {1}", Constants.Browsers.FireFox, version);
			}

			if (_lastSegment.ContainsText(Constants.Browsers.Safari, true))
			{
				var version = BrowserVersionResolver.Resolve(Constants.Browsers.Safari, _httpUserAgent);
				return string.Format("{0} {1}", Constants.Browsers.Safari, version);
			}

			if (_lastSegment.ContainsText(Constants.Browsers.Opera, true))
			{
				var version = BrowserVersionResolver.Resolve(Constants.Browsers.Opera, _httpUserAgent);
				return string.Format("{0} {1}", Constants.Browsers.Opera, version);
			}
			
			foreach (var value in _parenthesisSegmentValues)
			{
				if (value.ContainsText("MSIE", true))
				{
					var version = BrowserVersionResolver.Resolve("MSIE", _httpUserAgent);
					return string.Format("{0} {1}", Constants.Browsers.InternetExplorer, version);
				}
			}

			return Constants.Browsers.Unknown;
		}

		private string ResolvePlatform()
		{
			if (_httpUserAgent.ContainsText(Constants.Platforms.Macintosh, true))
			{
				return Constants.Platforms.Macintosh;
			}

			if (_httpUserAgent.ContainsText(Constants.Platforms.Windows, true))
			{
				return Constants.Platforms.Windows;
			}

			if (_httpUserAgent.ContainsText(Constants.Platforms.Linux, true))
			{
				return Constants.Platforms.Linux;
			}

			return Constants.Platforms.Unknown;
		}

		private string ResolveOperatingSystem()
		{
			foreach (var value in _parenthesisSegmentValues)
			{
				var temp = value.Trim();

				if (temp.ContainsText("Windows NT", true))
				{
					return WindowsOperatingSystemNameResolver.Resolve(value);
				}

				if (temp.ContainsText("Mac OS", true))
				{
					return temp;
				}

				if (temp.ContainsText("Linux", true))
				{
					return temp;
				}
			}

			return string.Empty;
		}
	}
}
