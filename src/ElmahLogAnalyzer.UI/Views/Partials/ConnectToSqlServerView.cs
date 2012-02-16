using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Views.Partials
{
	public partial class ConnectToSqlServerView : UserControl, IConnectToDatabaseConnectionInformationView
	{
		public ConnectToSqlServerView()
		{
			InitializeComponent();

			_useIntegratedSecurityCheckBox.Checked = true;
			_usernameTextBox.Enabled = false;
			_passwordTextBox.Enabled = false;

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

				ForceInputValidation();
			};

			_serverTextBox.TextChanged += (sender, args) => OnInputValidated(this, new OnValidatingEventArgs(AllRequiredFieldsHaveValues()));
			_databaseTextBox.TextChanged += (sender, args) => OnInputValidated(this, new OnValidatingEventArgs(AllRequiredFieldsHaveValues()));
			_usernameTextBox.TextChanged += (sender, args) => OnInputValidated(this, new OnValidatingEventArgs(AllRequiredFieldsHaveValues()));
		}

		public event EventHandler<OnValidatingEventArgs> OnInputValidated;

		public string File
		{
			get { throw new NotImplementedException(); }
		}

		public string Server
		{
			get { return _serverTextBox.Text; }
			set { _serverTextBox.Text = value; }
		}

		public string Port
		{
			get { throw new NotImplementedException(); }
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

		public void ForceInputValidation()
		{
			OnInputValidated(this, new OnValidatingEventArgs(AllRequiredFieldsHaveValues()));
		}

		private bool AllRequiredFieldsHaveValues()
		{
			var isValid = !string.IsNullOrWhiteSpace(Server) && !string.IsNullOrWhiteSpace(Database);

			if (!isValid)
			{
				return false;
			}

			if (!UseIntegratedSecurity && string.IsNullOrWhiteSpace(Username))
			{
				return false;
			}

			return true;
		}

		/*
		private void UseIntegratedSecurityCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			var isChecked = _useIntegratedSecurityCheckBox.Checked;

			if (isChecked)
			{
				_usernameTextBox.Text = string.Empty;
				_passwordTextBox.Text = string.Empty;
			}

			_usernameTextBox.Enabled = !isChecked;
			_passwordTextBox.Enabled = !isChecked;

			ForceInputValidation();
		}
		 */
	}
}
