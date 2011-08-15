using ElmahLogAnalyzer.Core.Domain.Export;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ExportPresenter
	{
		private readonly IErrorLogExporter _exporter;

		public ExportPresenter(IExportView view, IErrorLogExporter exporter)
		{
			View = view;
			_exporter = exporter;

			RegisterEvents();
		}

		public IExportView View { get; private set; }
		
		private void RegisterEvents()
		{
			_exporter.OnCompleted += delegate { View.CloseView(); };
			View.OnExport += View_OnExport;
		}

		private void View_OnExport(object sender, System.EventArgs e)
		{
			View.SetLoadingState();
			_exporter.Export();
		}
	}
}
