using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IExportView
	{
		event EventHandler OnLoaded;

		event EventHandler OnExport;

		event EventHandler OnCancel;

		string ExportToDirectory { get; set; }

		void SetLoadingState();

		void DisplayProgress(string progress);

		void DisplayError(Exception ex);

		void CloseView();
	}
}
