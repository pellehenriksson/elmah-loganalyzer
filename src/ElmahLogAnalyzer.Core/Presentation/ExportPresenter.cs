using System.Threading.Tasks;
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
			_exporter.OnProgressChanged += (sender, args) => View.DisplayProgress(args.Progress);
			_exporter.OnError += (sender, args) => View.DisplayError(args.Error);

			View.OnExport += View_OnExport;
			View.OnCancel += View_OnCancel;
		}

		private void View_OnCancel(object sender, System.EventArgs e)
		{
			_exporter.Cancel();
			View.CloseView();
		}

		private void View_OnExport(object sender, System.EventArgs e)
		{
			View.SetLoadingState();

			var task = new Task(_exporter.Export);
			task.Start();
		}
	}
}
