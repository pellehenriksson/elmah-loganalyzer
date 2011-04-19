using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using Crepido.ElmahOfflineViewer.UI.Views;

namespace Crepido.ElmahOfflineViewer.UI
{
	public partial class MainForm : Form
	{
		private readonly IErrorLogRepository _repository;

		public MainForm()
		{
			InitializeComponent();

			DisplayApplicationVersion();

			_repository = ServiceLocator.Resolve<IErrorLogRepository>();
			_repository.OnInitialized += RepositoryOnInitialized;

			HandleLoadingFromDirectory(ConfigurationManager.AppSettings["ErrorsDirectory"]);
		}
	
		private void SetLoadingState()
		{
			selectViewButton.Enabled = false;
			LoadView(new LoadingView());
		}

		private void SetReadyForWorkState()
		{
			selectViewButton.Enabled = true;
			mainPanel.Controls.Clear();
		}
		
		private void SetErrorLoadingState()
		{
			selectViewButton.Enabled = false;
			mainPanel.Controls.Clear();
			directoryToolStripStatusLabel.Text = string.Empty;
		}

		private void HandleLoadingFromDirectory(string directory)
		{
			SetLoadingState();
			directoryToolStripStatusLabel.Text = string.Format("Loading logs from: {0}", directory);

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
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(view);
			view.Dock = DockStyle.Fill;
		}
		
		private void DisplayError(object ex)
		{
			MessageBox.Show(this, ex.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void DisplayApplicationVersion()
		{
			versionStripStatusLabel.Text = string.Format("Build: {0} ({1})", Application.ProductVersion, GetType().Assembly.GetTypeOfBuild());
		}
		
		private void SelectDirectoryButtonClick(object sender, EventArgs e)
		{
			var result = _folderBrowserDialog.ShowDialog(this);

			if (result != DialogResult.OK)
			{
				return;
			}

			HandleLoadingFromDirectory(_folderBrowserDialog.SelectedPath);
		}

		private void SearchViewMenuItemClick(object sender, EventArgs e)
		{
			var presenter = ServiceLocator.Resolve<SearchPresenter>();
			LoadView(presenter.View as Control);
		}

		private void ReportsViewMenuItemClick(object sender, EventArgs e)
		{
			var presenter = ServiceLocator.Resolve<ReportPresenter>();
			LoadView(presenter.View as Control);
		}

		private void RepositoryOnInitialized(object sender, Core.Domain.RepositoryInitializedEventArgs e)
		{
			directoryToolStripStatusLabel.Text = string.Format("Current directory is: {0} Total number of logs: {1}", e.Directory, e.TotalNumberOfLogs);
		}
	}
}
