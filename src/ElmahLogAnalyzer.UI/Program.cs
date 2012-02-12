﻿using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
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

			main.OnRequestConnectToDatabaseDialog += (sender, args) =>
			{
				var presenter = ServiceLocator.Resolve<ConnectToDatabasePresenter>();
				var view = presenter.View as Form;
				var result = main.ShowDialog(view);

				if (result == DialogResult.OK)
				{
					var settings = (IConnectToDatabase)view;
					var connectionstring = ConnectionStringBuilder.Build(settings);
					
					// build connection string
					// resolve correct IDataSource

					// show some kind of loading screen
					// load view
					// handle exceptions
				}
			};

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
