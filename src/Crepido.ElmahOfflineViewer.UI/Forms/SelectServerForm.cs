using System;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Presentation;

namespace Crepido.ElmahOfflineViewer.UI.Forms
{
	public partial class SelectServerForm : Form, ISelectServerView
	{
		public SelectServerForm()
		{
			InitializeComponent();
			_errorGroupBox.Visible = false;
		}

		public event EventHandler OnConnectToServer;

		public string Url
		{
			get { return _urlTextBox.Text; }
		}

		public void DisplayErrorMessage(string message)
		{
			_errorMessageLabel.Text = message;
			_errorGroupBox.Visible = true;
		}

		public void ClearErrorMessage()
		{
			_errorMessageLabel.Text = string.Empty;
			_errorGroupBox.Visible = false;
		}

		public void CloseView()
		{
			DialogResult = DialogResult.OK;
		}

		private void ConnectButtonClick(object sender, EventArgs e)
		{
			if (OnConnectToServer != null)
			{
				OnConnectToServer(this, new EventArgs());
			}
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
