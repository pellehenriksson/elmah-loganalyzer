using System;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ErrorLogSelectedEventArgs : EventArgs
	{
		public ErrorLogSelectedEventArgs(ErrorLog errorLog)
		{
			ErrorLog = errorLog;
		}

		public ErrorLog ErrorLog { get; private set; }
	}
}
