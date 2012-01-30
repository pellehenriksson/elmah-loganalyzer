using System;
using System.Threading.Tasks;
using ElmahLogAnalyzer.Core.Domain.Export;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ExportPresenter
	{
		private readonly IErrorLogExporter _exporter;
		private readonly ISettingsManager _settingsManager;

		public ExportPresenter(IExportView view, IErrorLogExporter exporter, ISettingsManager settingsManager)
		{
			View = view;
			_exporter = exporter;
			_settingsManager = settingsManager;

			RegisterEvents();
		}

		public IExportView View { get; private set; }

		private void RegisterEvents()
		{
			_exporter.OnCompleted += delegate { View.CloseView(); };
			_exporter.OnProgressChanged += (sender, args) => View.DisplayProgress(args.Progress);
			_exporter.OnError += (sender, args) => View.DisplayError(args.Error);

			View.OnLoaded += ViewOnOnLoaded;
			View.OnExport += View_OnExport;
			View.OnCancel += View_OnCancel;
		}

		private void ViewOnOnLoaded(object sender, EventArgs eventArgs)
		{
			View.ExportToDirectory = _settingsManager.GetDefaultExportDirectory();
		}

		private void View_OnCancel(object sender, EventArgs e)
		{
			_exporter.Cancel();
			View.CloseView();
		}

		private void View_OnExport(object sender, EventArgs e)
		{
			View.SetLoadingState();

			var task = new Task(_exporter.Export);
			task.Start();
		}
	}
}
