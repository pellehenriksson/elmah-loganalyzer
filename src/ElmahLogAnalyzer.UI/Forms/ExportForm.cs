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
			
			AcceptButton = _exportButton;
			CancelButton = _cancelButton;
			SetInfoText();
		}

		public event EventHandler OnExport;

		public void SetLoadingState()
		{
			_exportButton.Enabled = false;
			_cancelButton.Enabled = false;
		}

		public void CloseView()
		{
			DialogResult = DialogResult.OK;
		}

		private void SetInfoText()
		{
			_infoLabel.Text = @"This will export all logs currently loaded into a SQL Server CE 4.0 database. 
								The database will be named ElmahLogAnalyzer_Dump.sdf and created in the application directory.
								You can use a tool like LINQPad to query to database.";
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
			Close();
		}
	}
}
