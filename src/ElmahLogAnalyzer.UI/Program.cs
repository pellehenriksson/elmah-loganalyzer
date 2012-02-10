using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Infrastructure.Dependencies;
using ElmahLogAnalyzer.Core.Presentation;
using ElmahLogAnalyzer.UI.Forms;

namespace ElmahLogAnalyzer.UI
{
	public static class Program
	{
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var main = ServiceLocator.Resolve<MainForm>();

			main.OnRequestExportDialog += (sender, args) =>
			{
			    var presenter = ServiceLocator.Resolve<ExportPresenter>();
				main.ShowDialog(presenter.View as Form);
			};

			main.OnRequestSettingsDialog += (sender, args) =>
			{
			    var presenter = ServiceLocator.Resolve<SettingsPresenter>();
				var result = main.ShowDialog(presenter.View as Form);
				if (result == DialogResult.OK)
				{
					main.ShowDisplaySettings();
				}
			};

			main.OnRequestAboutDialog += (sender, args) =>
			{
				var about = ServiceLocator.Resolve<AboutForm>();
				main.ShowDialog(about);
			};

			Application.Run(main);
		}
	}
}
