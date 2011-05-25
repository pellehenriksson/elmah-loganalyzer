using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class SearchHttpUserAgentInformationEventArgs : EventArgs
	{
		public SearchHttpUserAgentInformationEventArgs(string httpUserAgentString, string searchLauncher)
		{
			HttpUserAgentString = httpUserAgentString;
			SearchLauncher = searchLauncher;
		}

		public string HttpUserAgentString { get; private set; }

		public string SearchLauncher { get; private set; }
	}
}
