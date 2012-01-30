using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Dependencies;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;
using ElmahLogAnalyzer.Core.Presentation;
using ElmahLogAnalyzer.UI.Views;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class MainForm : Form
	{
		private readonly IErrorLogRepository _repository;
		private readonly ISettingsManager _settingsManager;

		public MainForm()
		{
			InitializeComponent();
			
			_settingsManager = ServiceLocator.Resolve<ISettingsManager>();
			_repository = ServiceLocator.Resolve<IErrorLogRepository>();
			
			_repository.OnInitialized += RepositoryOnInitialized;
			
			DisplaySettings();
			DisplayApplicationVersion();

		    var directory = Environment.GetCommandLineArgs()
                                        .Skip(1)
                                        .FirstOrDefault(arg => arg.HasValue());

            if (!directory.HasValue())
            {
            	directory = _settingsManager.GetDefaultLogsDirectory();

                if (!directory.HasValue() || !_settingsManager.GetLoadLogsFromDefaultDirectoryAtStartup())
                {
                    SetErrorLoadingState();
                    return;
                }
            }

		    HandleLoadingFromDirectory(directory);
		}
	
		private void SetLoadingState()
		{
			_showSearchViewButton.Enabled = false;
			_showReportViewButton.Enabled = false;
			_selectDirectoryButton.Enabled = false;
			_selectServerButton.Enabled = false;
			_exportButton.Enabled = false;
			_showSettingsViewButton.Enabled = false;

			LoadView(new LoadingView());
		}

		private void SetReadyForWorkState()
		{
			_showSearchViewButton.Enabled = true;
			_showReportViewButton.Enabled = true;
			_exportButton.Enabled = true;
			_selectDirectoryButton.Enabled = true;
			_selectServerButton.Enabled = true;
			_showSettingsViewButton.Enabled = true;
			
			LoadSearchView();
		}
		
		private void SetErrorLoadingState()
		{
			_showSearchViewButton.Enabled = false;
			_showReportViewButton.Enabled = false;
			_exportButton.Enabled = false;
			_selectDirectoryButton.Enabled = true;
			_selectServerButton.Enabled = true;
			_showSettingsViewButton.Enabled = true;
			
			_mainPanel.Controls.Clear();
			_directoryToolStripStatusLabel.Text = string.Empty;
		}

		private void HandleDownloadingLogs(NetworkConnection connection)
		{
			var downloader = ServiceLocator.Resolve<IErrorLogDownloader>();
			downloader.Download(connection);
			HandleLoadingFromDirectory(downloader.DownloadDirectory);
		}
		
		private void HandleLoadingFromDirectory(string directory)
		{
			SetLoadingState();
			_directoryToolStripStatusLabel.Text = string.Format("Loading logs from: {0}", directory);

			var thread = new Thread(InitializeRepository);
			thread.Start(directory);
		}

		private void InitializeRepository(object directory)
		{
			try
			{
				_repository.Initialize(directory as string);

				if (InvokeRequired)
				{
					this.InvokeEx(x => x.SetReadyForWorkState());
				}
				else
				{
					SetReadyForWorkState();
				}
			}
			catch (Exception ex)
			{
				if (InvokeRequired)
				{
					this.InvokeEx(x => x.DisplayError(ex));
					this.InvokeEx(x => x.SetErrorLoadingState());
				}
				else
				{
					DisplayError(ex);
					SetErrorLoadingState();
				}
			}
		}

		private void LoadView(Control view)
		{
			_mainPanel.Controls.Clear();
			_mainPanel.Controls.Add(view);
			view.Dock = DockStyle.Fill;
		}
		
		private void DisplayError(object ex)
		{
			var error = ex as Exception;
			
			if (error == null)
			{
				return;
			}

			MessageBox.Show(this, error.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void DisplayApplicationVersion()
		{
			_versionStripStatusLabel.Text = string.Format("Build: {0} ({1})", Application.ProductVersion, GetType().Assembly.GetTypeOfBuild());
		}
		
		private void DisplaySettings()
		{
			_settingsStripStatusLabel.Text = _settingsManager.ShouldGetAllLogs ? "Settings: All logs" : string.Format("Settings: {0} latest logs", _settingsManager.GetMaxNumberOfLogs());
		}

		private void SelectDirectoryButtonClick(object sender, EventArgs e)
		{
			_folderBrowserDialog.SelectedPath = _repository.Directory;

			var result = _folderBrowserDialog.ShowDialog(this);

			if (result != DialogResult.OK)
			{
				return;
			}

			HandleLoadingFromDirectory(_folderBrowserDialog.SelectedPath);
		}

		private void LoadSearchView()
		{
			var presenter = ServiceLocator.Resolve<SearchPresenter>();
			LoadView(presenter.View as Control);
		}

		private void ShowSearchViewButtonClick(object sender, EventArgs e)
		{
			LoadSearchView();
		}
		
		private void ShowReportViewButtonClick(object sender, EventArgs e)
		{
			var presenter = ServiceLocator.Resolve<ReportPresenter>();
			LoadView(presenter.View as Control);
		}

		private void ShowSettingsViewButtonClick(object sender, EventArgs e)
		{
			var presenter = ServiceLocator.Resolve<SettingsPresenter>();
			var view = presenter.View as Form;
			view.ShowDialog(this);

			DisplaySettings();
		}

		private void ShowAboutButtonClick(object sender, EventArgs e)
		{
			var view = new AboutForm();
			view.ShowDialog(this);
		}

		private void SelectServerButtonClick(object sender, EventArgs e)
		{
			var presenter = ServiceLocator.Resolve<ConnectToWebServerPresenter>();
			var view = presenter.View as Form;
			var dialogResult = view.ShowDialog(this);

			if (dialogResult == DialogResult.OK)
			{
				var connection = presenter.Connnection;
				HandleDownloadingLogs(connection);
			}
		}

		private void ExportButtonClick(object sender, EventArgs e)
		{
			var presenter = ServiceLocator.Resolve<ExportPresenter>();
			var view = presenter.View as Form;
			var dialogResult = view.ShowDialog(this);
		}
	}
}
