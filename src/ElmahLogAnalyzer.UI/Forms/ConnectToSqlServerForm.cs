using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class ConnectToSqlServerForm : Form, IConnectToSqlServerView
	{
		public ConnectToSqlServerForm()
		{
			InitializeComponent();
			CancelButton = _cancelButton;
			AcceptButton = _connectButton;

			_connectButton.Click += (sender, args) => OnConnectToDatabase(this, EventArgs.Empty);

			_cancelButton.Click += (sender, args) =>
			{
			    DialogResult = DialogResult.Cancel;
			    Close();
			};

			_useIntegratedSecurityCheckBox.CheckedChanged += (sender, args) =>
			{
				var isChecked = _useIntegratedSecurityCheckBox.Checked;

				if (isChecked)
				{
					_usernameTextBox.Text = string.Empty;
					_passwordTextBox.Text = string.Empty;
				}

				_usernameTextBox.Enabled = !isChecked;
				_passwordTextBox.Enabled = !isChecked;
			};

			ClearErrorMessage();
		}

		public event EventHandler OnConnectToDatabase;

		public ErrorLogSources Source
		{
			get { return ErrorLogSources.SqlServer; }
		}

		public string File
		{
			get { throw new System.NotImplementedException(); }
		}

		public string Server
		{
			get { return _serverTextBox.Text; }
		}

		public string Port
		{
			get { throw new System.NotImplementedException(); }
		}

		public string Database
		{
			get { return _databaseTextBox.Text; }
		}

		public string Username
		{
			get { return _usernameTextBox.Text; }
		}

		public string Password
		{
			get { return _passwordTextBox.Text; }
		}

		public bool UseIntegratedSecurity
		{
			get { return _useIntegratedSecurityCheckBox.Checked; }
		}

		public void CloseView()
		{
			DialogResult = DialogResult.OK;
			Close();
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
	}
}
