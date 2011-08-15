using System;

namespace ElmahLogAnalyzer.Core.Domain.Export
{
	public class ErrorLogExporterErrorEventArgs : EventArgs
	{
		public ErrorLogExporterErrorEventArgs(Exception error)
		{
			Error = error;
		}

		public Exception Error { get; private set; }
	}
}
