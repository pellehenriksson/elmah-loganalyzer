using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	public partial class SearchErrorDetailsView : UserControl
	{
		public SearchErrorDetailsView()
		{
			InitializeComponent();
		}
		
		public void DisplayError(ErrorLog error)
		{
			Clear();

			_timeLabel.Text = error.Time.ToString();
			_typeLabel.Text = error.Type;
			_sourceLabel.Text = error.Source;
			_userLabel.Text = error.User;
			_messageTextBox.Text = error.Message;
			_detailsTextBox.Text = error.Details;

			_urlLabel.Text = error.Url;
			_platformLabel.Text = error.ClientInformation.Platform;
			_operatingSystemLabel.Text = error.ClientInformation.OperatingSystem;
			_browserLabel.Text = error.ClientInformation.Browser;
			_ipAddressLabel.Text = error.LocalIpAddress;
			
			foreach (var variable in error.ServerVariables)
			{
				var node = _servervariablesListView.Items.Add(variable.Name);
				node.SubItems.Add(new ListViewItem.ListViewSubItem(node, variable.Value));
			}
			
			_servervariablesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		public void ClearView()
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x.ClearView());
			}
			else
			{
				Clear();
			}
		}

		private void Clear()
		{
			_timeLabel.Text = string.Empty;
			_typeLabel.Text = string.Empty;
			_sourceLabel.Text = string.Empty;
			_userLabel.Text = string.Empty;
			_messageTextBox.Text = string.Empty;
			_detailsTextBox.Text = string.Empty;

			_urlLabel.Text = string.Empty;
			_platformLabel.Text = string.Empty;
			_operatingSystemLabel.Text = string.Empty;
			_browserLabel.Text = string.Empty;
			_ipAddressLabel.Text = string.Empty;

			_servervariablesListView.Items.Clear();
		}
	}
}
