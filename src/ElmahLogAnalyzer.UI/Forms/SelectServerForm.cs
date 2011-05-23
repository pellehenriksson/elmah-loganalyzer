using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class SelectServerForm : Form, ISelectServerView
	{
		public SelectServerForm()
		{
			InitializeComponent();
			_errorGroupBox.Visible = false;
		}

		public event EventHandler<ConnectToServerEventArgs> OnConnectToServer;

		public string Url
		{
			get { return _urlTextBox.Text; }
			set { _urlTextBox.Text = value; }
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
				var args = new ConnectToServerEventArgs(
					_urlTextBox.Text, 
					_userNameTextBox.Text, 
					_passwordTextBox.Text,
				    _domainTextBox.Text);

				OnConnectToServer(this, args);
			}
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
