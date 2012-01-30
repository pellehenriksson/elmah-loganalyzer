using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class ExportForm : Form, IExportView
	{
		public ExportForm()
		{
			InitializeComponent();

			_exportToDirectoryTextBox.Enabled = false;
			AcceptButton = _exportButton;
			CancelButton = _cancelButton;
			SetInfoText();
			_progressLabel.Text = string.Empty;
		}

		public event EventHandler OnLoaded;

		public event EventHandler OnExport;

		public event EventHandler OnCancel;

		public string ExportToDirectory
		{
			get { return _exportToDirectoryTextBox.Text; }
			set { _exportToDirectoryTextBox.Text = value; }
		}

		public void SetLoadingState()
		{
			_exportButton.Enabled = false;
		}

		public void DisplayProgress(string progress)
		{
			_progressLabel.InvokeEx(x => x.Text = progress);
		}

		public void DisplayError(Exception ex)
		{
			this.InvokeEx(x => x.DisplayErrorDialog(ex));
		}
		
		public void CloseView()
		{
			DialogResult = DialogResult.OK;
		}

		private void DisplayErrorDialog(Exception ex)
		{
			MessageBox.Show(this, ex.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void SetInfoText()
		{
			_infoLabel.Text = @"This will export all logs currently loaded, into a SQL Server CE 4.0 database. 
								The database will be named ElmahLogAnalyzer_Dump.sdf and places in the directory below.
								You can use a tool like LINQPad to query the database.";
		}
		
		private void ExportButtonClick(object sender, EventArgs e)
		{
			if (OnExport != null)
			{
				OnExport(this, new EventArgs());
			}
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			if (OnCancel != null)
			{
				OnCancel(this, new EventArgs());
			}
		}

		private void ExportFormLoad(object sender, EventArgs e)
		{
			if (OnLoaded != null)
			{
				OnLoaded(this, new EventArgs());
			}
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			if (OnCancel != null)
			{
				OnCancel(this, new EventArgs());
			}
		}

		private void SelectExportToDirectoryButtonClick(object sender, EventArgs e)
		{
			if (_folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				_exportToDirectoryTextBox.Text = _folderBrowserDialog.SelectedPath;
			}
		}
	}
}
