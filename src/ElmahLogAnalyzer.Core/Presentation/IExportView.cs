using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IExportView
	{
		event EventHandler OnExport;

		void SetLoadingState();
		
		void CloseView();
	}
}
