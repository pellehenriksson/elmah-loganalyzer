using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class ConnectToWebServerForm : Form, IConnectToWebServerView
	{
		public ConnectToWebServerForm()
		{
			InitializeComponent();
			_errorGroupBox.Visible = false;
			_urlComboBox.SelectedIndexChanged += OnUrlComboBoxOnSelectedIndexChanged;
		}
		
		public event EventHandler<ConnectToServerEventArgs> OnConnectToServer;

		public event EventHandler<ConnectionSelectedEventArgs> OnConnectionSelected;

		public string Url
		{
			get { return _urlComboBox.SelectedText; }
			set { _urlComboBox.SelectedText = value; }
		}

		public void LoadConnectionUrls(List<string> urls)
		{
			_urlComboBox.Items.Clear();
			foreach (var url in urls)
			{
				_urlComboBox.Items.Add(url);
			}
		}

		public void DisplayConnection(string username, string password, string domain)
		{
			_userNameTextBox.Text = username;
			_passwordTextBox.Text = password;
			_domainTextBox.Text = domain;
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
		
		private void OnUrlComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (OnConnectionSelected != null)
			{
				OnConnectionSelected(this, new ConnectionSelectedEventArgs((string)_urlComboBox.Text));
			}
		}

		private void ConnectButtonClick(object sender, EventArgs e)
		{
			if (OnConnectToServer != null)
			{
				var args = new ConnectToServerEventArgs(
					_urlComboBox.Text, 
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
