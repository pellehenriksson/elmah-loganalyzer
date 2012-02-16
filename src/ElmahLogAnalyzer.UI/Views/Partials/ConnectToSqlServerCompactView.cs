using System;
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
			_fileTextBox.TextChanged += (sender, args) => OnInputValidated(this, new OnValidatingEventArgs(AllRequiredFieldsHaveValues()));
		}

		public event EventHandler<OnValidatingEventArgs> OnInputValidated;

		public string File
		{
			get { return _fileTextBox.Text; }
		}

		public string Server
		{
			get { throw new NotImplementedException(); }
		}

		public string Port
		{
			get { throw new NotImplementedException(); }
		}

		public string Database
		{
			get { throw new NotImplementedException(); }
		}

		public string Username
		{
			get { throw new NotImplementedException(); }
		}

		public string Password
		{
			get { throw new NotImplementedException(); }
		}

		public bool UseIntegratedSecurity
		{
			get { throw new NotImplementedException(); }
		}

		public void ForceInputValidation()
		{
			OnInputValidated(this, new OnValidatingEventArgs(AllRequiredFieldsHaveValues()));
		}

		private bool AllRequiredFieldsHaveValues()
		{
			return !string.IsNullOrWhiteSpace(File);
		}

		private void BrowseButtonClick(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog { Filter = "Microsoft SQL Server Compact files (*.sdf)|*.sdf|All files (*.*)|*.*" };

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				_fileTextBox.Text = dialog.FileName;
			}
		}
	}
}
