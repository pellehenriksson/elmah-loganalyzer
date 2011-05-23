using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class SearchHttpUserAgentInformationEventArgs : EventArgs
	{
		public SearchHttpUserAgentInformationEventArgs(string httpUserAgentString)
		{
			HttpUserAgentString = httpUserAgentString;
		}

		public string HttpUserAgentString { get; private set; }
	}
}
