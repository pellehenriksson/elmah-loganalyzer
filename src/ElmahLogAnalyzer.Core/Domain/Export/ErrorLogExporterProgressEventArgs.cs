using System;

namespace ElmahLogAnalyzer.Core.Domain.Export
{
	public class ErrorLogExporterProgressEventArgs : EventArgs
	{
		public ErrorLogExporterProgressEventArgs(string progress)
		{
			Progress = progress;
		}

		public string Progress { get; private set; }
	}
}
