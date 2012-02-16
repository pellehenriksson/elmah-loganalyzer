using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;
using ElmahLogAnalyzer.UI.Views;

namespace ElmahLogAnalyzer.UI
{
	public partial class Container : Form
	{
		private readonly WelcomeView _welcomeView;
		private readonly LoadingView _loadingView;

		public Container()
		{
			InitializeComponent();
			DisplayApplicationVersion();

			_welcomeView = new WelcomeView();
			_loadingView = new LoadingView();

			_connectToDirectoryMenuItem.Click += (sender, args) => OnRequestConnectToDirectoryDialog(this, EventArgs.Empty);
			_connectToDatabaseMenuItem.Click += (sender, args) => OnRequestConnectToDatabaseDialog(this, EventArgs.Empty);
			_connectToWebServerMenuItem.Click += (sender, args) => OnRequestConnectToWebServerDialog(this, EventArgs.Empty);
			_disconnectMenuItem.Click += (sender, args) => SetWelcomeState();
			_exitMenuItem.Click += (sender, args) => OnRequestExit(this, EventArgs.Empty);

			_showSearchViewButton.Click += (sender, args) => OnRequestSearchView(this, EventArgs.Empty);
			_showReportViewButton.Click += (sender, args) => OnRequestReportView(this, EventArgs.Empty);
			_showExportButton.Click += (sender, args) => OnRequestExportDialog(this, EventArgs.Empty);
			_showSettingsViewButton.Click += (sender, args) => OnRequestSettingsDialog(this, EventArgs.Empty);
			_showAboutButton.Click += (sender, args) => OnRequestAboutDialog(this, EventArgs.Empty);
		}

		public event EventHandler OnRequestConnectToDirectoryDialog;

		public event EventHandler OnRequestConnectToWebServerDialog;

		public event EventHandler OnRequestConnectToDatabaseDialog;

		public event EventHandler OnRequestSearchView;

		public event EventHandler OnRequestReportView;

		public event EventHandler OnRequestExportDialog;

		public event EventHandler OnRequestSettingsDialog;

		public event EventHandler OnRequestAboutDialog;

		public event EventHandler OnRequestExit;

		public void ShowView(UserControl view)
		{
			_mainPanel.Controls.Clear();
			_mainPanel.Controls.Add(view);
			view.Dock = DockStyle.Fill;
		}

		public DialogResult ShowDialog(Form dialog)
		{
			dialog.ShowDialog(this);
			return dialog.DialogResult;
		}
		
		public void ShowError(Exception ex)
		{
			MessageBox.Show(this, ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void DisplaySettings(ISettingsManager settings)
		{
			_settingsStripStatusLabel.Text = settings.ShouldGetAllLogs ? "Settings: All logs" : string.Format("Settings: {0} latest logs", settings.GetMaxNumberOfLogs());
		}

		public void DisplayStatus(string message)
		{
			_directoryToolStripStatusLabel.Text = message;
		}

		public void SetWelcomeState()
		{
			SetInitialState();
			ShowView(_welcomeView);
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

			ShowView(_loadingView);
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
		
		private void DisplayApplicationVersion()
		{
			_versionStripStatusLabel.Text = string.Format("Build: {0} ({1})", Application.ProductVersion, GetType().Assembly.GetTypeOfBuild());
		}
	}
}
