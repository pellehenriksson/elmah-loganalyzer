using System;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Presentation;

namespace Crepido.ElmahOfflineViewer.UI.Forms
{
	public partial class SelectServerForm : Form, ISelectServerView
	{
		public SelectServerForm()
		{
			InitializeComponent();
		}

		public event EventHandler OnConnectToServer;

		public string Url
		{
			get { return _urlTextBox.Text; }
		}

		public void DisplayErrorMessage()
		{
			throw new NotImplementedException();
		}

		private void ConnectButtonClick(object sender, EventArgs e)
		{
			if (OnConnectToServer != null)
			{
				OnConnectToServer(this, new EventArgs());
			}
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
