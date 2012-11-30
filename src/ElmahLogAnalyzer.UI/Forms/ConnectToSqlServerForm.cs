using System;
using System.Collections.Generic;
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

			_connectionComboBox.SelectedIndexChanged += (sender, args) =>
			{
				if (OnConnectionSelected != null)
				{
					OnConnectionSelected(this, new ConnectionSelectedEventArgs(_connectionComboBox.Text));
				}
			};

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

		public event EventHandler<ConnectionSelectedEventArgs> OnConnectionSelected;

		public ErrorLogSources Source
		{
			get { return ErrorLogSources.SqlServer; }
		}
		
		public string Server
		{
			get { return _serverTextBox.Text; }
			set { _serverTextBox.Text = value; }
		}

		public string Schema
		{
			get { return _schemaTextBox.Text; }
			set { _schemaTextBox.Text = value; }
		}

        public string Application
        {
            get { return _applicationTextBox.Text; }
            set { _applicationTextBox.Text = value; }
        }

	    public string Port
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		public string Database
		{
			get { return _databaseTextBox.Text; }
			set { _databaseTextBox.Text = value; }
		}

		public string Username
		{
			get { return _usernameTextBox.Text; }
			set { _usernameTextBox.Text = value; }
		}

		public string Password
		{
			get { return _passwordTextBox.Text; }
			set { _passwordTextBox.Text = value; }
		}
		
		public bool UseIntegratedSecurity
		{
			get { return _useIntegratedSecurityCheckBox.Checked; }
			set { _useIntegratedSecurityCheckBox.Checked = value; }
		}

		public void CloseView()
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		public void LoadConnections(List<string> connections)
		{
			_connectionComboBox.Items.Clear();
			_connectionComboBox.DataSource = connections;
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
