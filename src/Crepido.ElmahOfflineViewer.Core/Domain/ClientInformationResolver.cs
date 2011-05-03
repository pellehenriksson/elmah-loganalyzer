using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;

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
			if (httpUserAgent == null)
			{
				throw new ArgumentNullException("httpUserAgent");	
			}

			if (!httpUserAgent.HasValue())
			{
				return new ClientInformation();
			}

			_httpUserAgent = httpUserAgent;

			SplitHttpUserAgent(httpUserAgent);

			var information = new ClientInformation();

			information.Browser = ResolveBrowser();
			information.Platform = ResolvePlatform();
			information.OperatingSystem = ResolveOperatingSystem();

			return information;
		}

		private void SplitHttpUserAgent(string httpUserAgent)
		{
			var leftParenthesisIndex = _httpUserAgent.IndexOf('(');
			var rightParenthesisIndex = _httpUserAgent.IndexOf(')');
			
			var parenthesisSegmentLength = rightParenthesisIndex - leftParenthesisIndex;

			_parenthesisSegment = httpUserAgent.Substring(leftParenthesisIndex, parenthesisSegmentLength);
			_parenthesisSegmentValues = _parenthesisSegment.Split(';');
			_lastSegment = httpUserAgent.Substring(rightParenthesisIndex);
		}

		private string ResolveBrowser()
		{
			if (_lastSegment.ContainsText(Constants.Browsers.Chrome, true))
			{
				return Constants.Browsers.Chrome;
			}

			if (_lastSegment.ContainsText(Constants.Browsers.FireFox, true))
			{
				return Constants.Browsers.FireFox;
			}

			if (_lastSegment.ContainsText(Constants.Browsers.Safari, true))
			{
				return Constants.Browsers.Safari;
			}
			
			foreach (var value in _parenthesisSegmentValues)
			{
				if (value.ContainsText("MSIE", true))
				{
					return Constants.Browsers.InternetExplorer;
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

			return Constants.Platforms.Unknown;
		}

		private string ResolveOperatingSystem()
		{
			foreach (var value in _parenthesisSegmentValues)
			{
				if (value.ContainsText("Windows NT", true))
				{
					return value;
				}

				if (value.ContainsText("Mac OS", true))
				{
					return value;
				}
			}

			return string.Empty;
		}
	}
}
