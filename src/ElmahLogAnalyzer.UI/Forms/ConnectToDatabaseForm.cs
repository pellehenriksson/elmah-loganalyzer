using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;
using ElmahLogAnalyzer.UI.Views.Partials;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class ConnectToDatabaseForm : Form, IConnectToDatabaseView
	{
		public ConnectToDatabaseForm()
		{
			InitializeComponent();

			CancelButton = _cancelButton;
			AcceptButton = _connectButton;
		}

		public ErrorLogSourcesEnum Source
		{
			get { return GetCurrentSelectedErrorLogSource(); }

			set { throw new NotImplementedException("todo"); }
		}
		
		public string File
		{
			get { return ConnectionInformation.File; }
			set { throw new NotImplementedException(); }
		}

		public string Server
		{
			get { return ConnectionInformation.Server; }
			set { ConnectionInformation.Server = value; }
		}

		public string Port
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		public string Database
		{
			get { return ConnectionInformation.Database; }
			set { ConnectionInformation.Database = value;  }
		}

		public string Username
		{
			get { return ConnectionInformation.Username; }
			set { ConnectionInformation.Username = value; }
		}

		public string Password
		{
			get { return ConnectionInformation.Password; }
			set { ConnectionInformation.Password = value; }
		}

		public bool UseIntegratedSecurity
		{
			get { return ConnectionInformation.UseIntegratedSecurity; }
			set { ConnectionInformation.UseIntegratedSecurity = value; }
		}

		private IConnectToDatabaseConnectionInformationView ConnectionInformation
		{
			get { return (IConnectToDatabaseConnectionInformationView)_viewPanel.Controls[0]; }
		}

		public void LoadDatabaseOptions(List<NameValuePair> options)
		{
			_databaseTypesComboBox.Items.Clear();
			foreach (var option in options)
			{
				_databaseTypesComboBox.Items.Add(option);
			}

			_databaseTypesComboBox.SelectedIndex = 0;
		}

		private void DatabaseTypesComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			var source = GetCurrentSelectedErrorLogSource();

			_viewPanel.Controls.Clear();

			if (source == ErrorLogSourcesEnum.SqlServer)
			{
				_viewPanel.Controls.Add(new ConnectToSqlServerView());
			}

			if (source == ErrorLogSourcesEnum.SqlServerCompact)
			{
				_viewPanel.Controls.Add(new ConnectToSqlServerCompactView());
			}
		}

		private ErrorLogSourcesEnum GetCurrentSelectedErrorLogSource()
		{
			var item = _databaseTypesComboBox.Items[_databaseTypesComboBox.SelectedIndex] as NameValuePair;
			var source = (ErrorLogSourcesEnum)Enum.Parse(typeof(ErrorLogSourcesEnum), item.Value);
			return source;
		}
		
		private void ConnectButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
