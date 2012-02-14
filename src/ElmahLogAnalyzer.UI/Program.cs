using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Dependencies;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;
using ElmahLogAnalyzer.Core.Presentation;
using ElmahLogAnalyzer.UI.Forms;
using ElmahLogAnalyzer.UI.Views;

namespace ElmahLogAnalyzer.UI
{
	public static class Program
	{
		private static ISettingsManager _settingsManager;
		private static Container _container;

		[STAThread]
		public static void Main()
		{
			//// todo: handle loading logs at startup
			//// todo: handle if exe started with arguments

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			_settingsManager = ServiceLocator.Resolve<ISettingsManager>();

			_container = ServiceLocator.Resolve<Container>();

			_container.SetWelcomeState();
			_container.DisplaySettings(_settingsManager);

			_container.OnRequestConnectToDirectoryDialog += (sender, args) =>
			{
				var dialog = new FolderBrowserDialog
				{
				    Description = "Select a folder with ELMAH log files",
				    SelectedPath = _settingsManager.GetDefaultLogsDirectory()
				};

				var result = dialog.ShowDialog(_container);
				
				if (result == DialogResult.OK)
				{
					InitializeNewErrorLogSource(ErrorLogSourcesEnum.Files, dialog.SelectedPath, null);
				}
			};

			_container.OnRequestConnectToWebServerDialog += (sender, args) =>
			{
				var presenter = ServiceLocator.Resolve<ConnectToWebServerPresenter>();
				var view = presenter.View as Form;
				var result = _container.ShowDialog(view);

				if (result == DialogResult.OK)
				{
					InitializeNewErrorLogSource(ErrorLogSourcesEnum.Files, string.Empty, presenter.Connnection);
				}
			};

			_container.OnRequestConnectToDatabaseDialog += (sender, args) =>
			{
				var presenter = ServiceLocator.Resolve<ConnectToDatabasePresenter>();
				var view = presenter.View as Form;
				var result = _container.ShowDialog(view);

				if (result == DialogResult.OK)
				{
					var settings = (IConnectToDatabase)view;
					var connectionstring = ConnectionStringBuilder.Build(settings);

					InitializeNewErrorLogSource(settings.Source, connectionstring, null);
				}
			};

			_container.OnRequestSearchView += (sender, args) =>
			{
				var presenter = ServiceLocator.Resolve<SearchPresenter>();
				_container.ShowView(presenter.View as UserControl);
			};

			_container.OnRequestReportView += (sender, args) =>
			{
				var presenter = ServiceLocator.Resolve<ReportPresenter>();
				_container.ShowView(presenter.View as UserControl);
			};

			_container.OnRequestExportDialog += (sender, args) =>
			{
			    var presenter = ServiceLocator.Resolve<ExportPresenter>();
				_container.ShowDialog(presenter.View as Form);
			};

			_container.OnRequestSettingsDialog += (sender, args) =>
			{
			    var presenter = ServiceLocator.Resolve<SettingsPresenter>();
				var result = _container.ShowDialog(presenter.View as Form);
				
				if (result == DialogResult.OK)
				{
					_container.DisplaySettings(_settingsManager);
				}
			};

			_container.OnRequestAboutDialog += (sender, args) =>
			{
				var about = ServiceLocator.Resolve<AboutForm>();
				_container.ShowDialog(about);
			};

			Application.Run(_container);
		}
		
		private static void InitializeNewErrorLogSource(ErrorLogSourcesEnum source, string connection, NetworkConnection networkConnection)
		{
			_container.SetLoadingState();

			DataSourceScopeController.SetNewSource(source, connection);
			
			//// need to know the download directory before resolving 
			//// and before downloading
			DownloadLogs(networkConnection);

			var downloadLogsTask = new Task(() => { return; });

			var repository = ServiceLocator.Resolve<IErrorLogRepository>();
			var viewPresenter = ServiceLocator.Resolve<SearchPresenter>();

			var initRepositoryTask = downloadLogsTask.ContinueWith(previousTask =>
			{
				if (previousTask.Exception != null)
				{
					_container.InvokeEx(m => m.ShowView(new ErrorView(previousTask.Exception)));
					_container.InvokeEx(m => m.SetInitialState());
					return;
				}

				repository.Initialize();
			});

			var updateUiTask = initRepositoryTask.ContinueWith(previousTask =>
			{
				if (previousTask.Exception != null)
				{
					_container.InvokeEx(m => m.ShowView(new ErrorView(previousTask.Exception)));
					_container.InvokeEx(m => m.SetInitialState());
					return;
				}

				_container.InvokeEx(m => m.SetReadyForWorkState());
				_container.InvokeEx(m => m.DisplayStatus("Connection: " + DataSourceScopeController.Connection));
				_container.InvokeEx(m => m.ShowView(viewPresenter.View as UserControl));
			});
			
			downloadLogsTask.Start();
		}
		
		private static void DownloadLogs(NetworkConnection networkConnection)
		{
			if (networkConnection == null)
			{
				return;
			}
			
			var downloader = ServiceLocator.Resolve<ErrorLogDownloader>();
			downloader.Download(networkConnection);

			DataSourceScopeController.SetNewSource(ErrorLogSourcesEnum.Files, downloader.DownloadDirectory);
		}
	}
}
