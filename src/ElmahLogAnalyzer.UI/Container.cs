using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;
using ElmahLogAnalyzer.UI.Views;

namespace ElmahLogAnalyzer.UI
{
	public partial class Container : Form
	{
		private readonly WelcomeView _welcomeView = new WelcomeView();
		private readonly LoadingView _loadingView = new LoadingView();

		public Container()
		{
			InitializeComponent();
			RegisterEvents();
			DisplayApplicationVersion();

			_connectToAccessMenuItem.Enabled = false;
		}

		public event EventHandler<ApplicationCommandEventArgs> OnApplicationCommand;
		
		public void DisplayView(UserControl view)
		{
			_mainPanel.Controls.Clear();
			_mainPanel.Controls.Add(view);
			view.Dock = DockStyle.Fill;
		}

		public DialogResult DisplayDialog(Form dialog)
		{
			dialog.ShowDialog(this);
			return dialog.DialogResult;
		}
		
		public void DisplayError(Exception ex)
		{
			MessageBox.Show(this, ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		public void SetWelcomeState()
		{
			SetInitialState();
			DisplayView(_welcomeView);
		}

		public void SetInitialState()
		{
			_connectToDirectoryMenuItem.Enabled = true;
			_connectToWebServerMenuItem.Enabled = true;
			_connectToDatabaseMenuItem.Enabled = true;
			_disconnectMenuItem.Enabled = false;

			_showSearchViewButton.Enabled = false;
			_showReportViewButton.Enabled = false;
			_showExportButton.Enabled = false;
			_showSettingsViewButton.Enabled = true;

			_directoryToolStripStatusLabel.Text = string.Empty;
		}
		
		public void SetLoadingState()
		{
			_connectToDirectoryMenuItem.Enabled = false;
			_connectToWebServerMenuItem.Enabled = false;
			_connectToDatabaseMenuItem.Enabled = false;

			_showSearchViewButton.Enabled = false;
			_showReportViewButton.Enabled = false;
			_showExportButton.Enabled = false;

			_directoryToolStripStatusLabel.Text = string.Empty;

			DisplayView(_loadingView);
		}
		
		public void SetReadyForWorkState()
		{
			_connectToDirectoryMenuItem.Enabled = true;
			_connectToWebServerMenuItem.Enabled = true;
			_connectToDatabaseMenuItem.Enabled = true;
			_disconnectMenuItem.Enabled = true;

			_showSearchViewButton.Enabled = true;
			_showReportViewButton.Enabled = true;
			_showExportButton.Enabled = true;
			_showSettingsViewButton.Enabled = true;
		}

		public void DisplaySettings(ISettingsManager settings)
		{
			_settingsStripStatusLabel.Text = settings.ShouldGetAllLogs ? "Settings: All logs" : string.Format("Settings: {0} latest logs", settings.GetMaxNumberOfLogs());
		}

		public void DisplayConnectionInformation(ErrorLogSources source, string connection)
		{
			_directoryToolStripStatusLabel.Text = ConnectionInformationHelper.GetInformation(source, connection);
		}
		
		private void DisplayApplicationVersion()
		{
			_versionStripStatusLabel.Text = string.Format("Build: {0} ({1})", Application.ProductVersion, GetType().Assembly.GetTypeOfBuild());
		}

		private void RegisterEvents()
		{
			_connectToDirectoryMenuItem.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.ConnectToDirectory);
			_connectToWebServerMenuItem.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.ConnectToWebServer);
			_connectToSqlServerMenuItem.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.ConnectToSqlServerDatabase);
			_connectToSqlServerCompactMenuItem.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.ConnectToSqlServerCompactDatabase);
			_connectToAccessMenuItem.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.ConnectToAccessDatabase);
			_disconnectMenuItem.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.Disconnect);
			_exitMenuItem.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.Exit);
			_showSearchViewButton.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.DisplaySearchView);
			_showReportViewButton.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.DisplayReportsView);
			_showExportButton.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.DislayExportDialog);
			_showSettingsViewButton.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.DisplaySettingsDialog);
			_showAboutButton.Click += (sender, args) => RaiseApplicationCommand(ApplicationCommands.DisplayAboutDialog);
		}

		private void RaiseApplicationCommand(ApplicationCommands command)
		{
			if (OnApplicationCommand == null)
			{
				return;
			}

			OnApplicationCommand(this, new ApplicationCommandEventArgs(command));
		}
	}
}
