using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;
using ElmahLogAnalyzer.UI.Views.Partials;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class ConnectToDatabaseForm : Form, IConnectToDatabase
	{
		public ConnectToDatabaseForm()
		{
			InitializeComponent();

			CancelButton = _cancelButton;
			AcceptButton = _connectButton;

			InitializeViews();
		}

		public ErrorLogSourcesEnum Source
		{
			get { return GetCurrentSelectedErrorLogSource(); }
		}
		
		public string File
		{
			get { return ConnectionInformation.File; }
		}

		public string Server
		{
			get { return ConnectionInformation.Server; }
		}

		public string Port
		{
			get { return ConnectionInformation.Port; }
		}

		public string Database
		{
			get { return ConnectionInformation.Database; }
		}

		public string Username
		{
			get { return ConnectionInformation.Username; }
		}

		public string Password
		{
			get { return ConnectionInformation.Password; }
		}

		public bool UseIntegratedSecurity
		{
			get { return ConnectionInformation.UseIntegratedSecurity; }
		}

		private IConnectToDatabaseConnectionInformationView ConnectionInformation
		{
			get { return (IConnectToDatabaseConnectionInformationView)_viewPanel.Controls[0]; }
		}

		private void InitializeViews()
		{
			_databaseTypesComboBox.Items.Clear();

			_databaseTypesComboBox.Items.Add(new ViewSelection(ErrorLogSourcesEnum.SqlServer, new ConnectToSqlServerView()));
			_databaseTypesComboBox.Items.Add(new ViewSelection(ErrorLogSourcesEnum.SqlServerCompact, new ConnectToSqlServerCompactView()));

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
			var item = _databaseTypesComboBox.Items[_databaseTypesComboBox.SelectedIndex] as ViewSelection;
			return item.ErrorLogSource;
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

		public class ViewSelection
		{
			public ViewSelection(ErrorLogSourcesEnum errorLogSource, IConnectToDatabaseConnectionInformationView view)
			{
				ErrorLogSource = errorLogSource;
				View = view;
			}

			public ErrorLogSourcesEnum ErrorLogSource { get; private set; }
			
			public IConnectToDatabaseConnectionInformationView View { get; private set; }

			public override string ToString()
			{
				return ErrorLogSource.GetDescription();
			}
		}
	}
}
