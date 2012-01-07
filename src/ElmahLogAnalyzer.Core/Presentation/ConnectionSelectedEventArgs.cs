using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectionSelectedEventArgs : EventArgs
	{
		public ConnectionSelectedEventArgs(string url)
		{
			Url = url;
		}

		public string Url { get; private set; }
	}
}
