using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Views.Partials
{
	public partial class ConnectToSqlServerCompactView : UserControl, IConnectToDatabaseConnectionInformationView
	{
		public ConnectToSqlServerCompactView()
		{
			InitializeComponent();
			_fileTextBox.Enabled = false;
		}

		public string File
		{
			get { return _fileTextBox.Text; }
			set { throw new System.NotImplementedException(); }
		}

		public string Server
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
		}

		public string Port
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
		}

		public string Database
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
		}

		public string Username
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
		}

		public string Password
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
		}

		public bool UseIntegratedSecurity
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
		}

		private void BrowseButtonClick(object sender, System.EventArgs e)
		{
			var dialog = new OpenFileDialog { Filter = "Microsoft SQL Server Compact files (*.sdf)|*.sdf|All files (*.*)|*.*" };

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_fileTextBox.Text = dialog.FileName;
			}
		}
	}
}
