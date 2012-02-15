using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Views.Partials
{
	public partial class ConnectToSqlServerView : UserControl, IConnectToDatabaseConnectionInformationView
	{
		private readonly ErrorProvider _errorProvider = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };
		
		public ConnectToSqlServerView()
		{
			InitializeComponent();

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
			_errorProvider.SetError(_serverTextBox, string.IsNullOrWhiteSpace(Server) ? "Please provide a server name" : string.Empty);
			_errorProvider.SetError(_databaseTextBox, string.IsNullOrWhiteSpace(Database) ? "Please provide a database name" : string.Empty);

			if (!UseIntegratedSecurity)
			{
				_errorProvider.SetError(_usernameTextBox, string.IsNullOrWhiteSpace(Username) ? "Please provide a user name" : string.Empty);
			}
			else
			{
				_errorProvider.SetError(_usernameTextBox, string.Empty);
			}

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
	}
}
