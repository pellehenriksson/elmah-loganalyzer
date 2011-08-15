using System;

namespace ElmahLogAnalyzer.Core.Domain.Export
{
	public interface IErrorLogExporter
	{
		event EventHandler<ErrorLogExporterCompleteEventArgs> OnCompleted;

		event EventHandler<ErrorLogExporterErrorEventArgs> OnError;

		event EventHandler<ErrorLogExporterProgressEventArgs> OnProgressChanged;

		void Export();

		void Cancel();
	}
}