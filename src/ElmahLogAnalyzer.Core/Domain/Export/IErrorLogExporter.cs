using System;

namespace ElmahLogAnalyzer.Core.Domain.Export
{
	public interface IErrorLogExporter
	{
		event EventHandler OnCompleted;

		event EventHandler<ErrorLogExporterErrorEventArgs> OnError;

		event EventHandler<ErrorLogExporterProgressEventArgs> OnProgressChanged;

		void Export();

		void Cancel();
	}
}