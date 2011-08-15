using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IExportView
	{
		event EventHandler OnExport;

		event EventHandler OnCancel;

		void SetLoadingState();

		void DisplayProgress(string progress);

		void DisplayError(Exception ex);

		void CloseView();
	}
}
