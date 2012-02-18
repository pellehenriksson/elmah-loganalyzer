using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class ConnectToAccessForm : Form, IConnectToAccessView
	{
		public ConnectToAccessForm()
		{
			InitializeComponent();
			CancelButton = _cancelButton;
			AcceptButton = _connectButton;

			ClearErrorMessage();

			_connectButton.Click += (sender, args) => OnConnectToDatabase(this, EventArgs.Empty);

			_cancelButton.Click += (sender, args) =>
			{
				DialogResult = DialogResult.Cancel;
				Close();
			};

			_browseButton.Click += (sender, args) =>
			{
			    var dialog = new OpenFileDialog
			    {
					Filter = "Microsoft Access Database|*.mdb",
			        Multiselect = false,
			        CheckPathExists = true,
			    };

			    if (dialog.ShowDialog(this) == DialogResult.OK)
			    {
			        Server = dialog.FileName;
			    }
			};
		}

		public event EventHandler OnConnectToDatabase;

		public ErrorLogSources Source
		{
			get { return ErrorLogSources.Access; }
		}

		public string Server
		{
			get { return _serverTextBox.Text; }
			set { _serverTextBox.Text = value; }
		}

		public string Port
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		public string Database
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		public string Username
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		public string Password
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		public bool UseIntegratedSecurity
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
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
