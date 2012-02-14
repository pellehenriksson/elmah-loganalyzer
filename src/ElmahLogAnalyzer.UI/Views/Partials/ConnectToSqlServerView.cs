using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Views.Partials
{
	public partial class ConnectToSqlServerView : UserControl, IConnectToDatabaseConnectionInformationView
	{
		public ConnectToSqlServerView()
		{
			InitializeComponent();
		}

		public string File
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
		}

		public string Server
		{
			get { return _serverTextBox.Text; }
			set { _serverTextBox.Text = value; }
		}

		public string Port
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
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

		private void UseIntegratedSecurityCheckBoxCheckedChanged(object sender, System.EventArgs e)
		{
			var isChecked = _useIntegratedSecurityCheckBox.Checked;

			if (isChecked)
			{
				_usernameTextBox.Text = string.Empty;
				_passwordTextBox.Text = string.Empty;
			}

			_usernameTextBox.Enabled = !isChecked;
			_passwordTextBox.Enabled = !isChecked;
		}
	}
}
