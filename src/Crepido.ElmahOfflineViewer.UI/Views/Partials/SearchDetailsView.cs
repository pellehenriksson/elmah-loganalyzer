using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	public partial class SearchDetailsView : UserControl
	{
		public SearchDetailsView()
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

			_formsListView.LoadValues(error.FormValues);
			_cookiesListView.LoadValues(error.Cookies);
			_querystringListView.LoadValues(error.QuerystringValues);
			_serverVariablesListView.LoadValues(error.ServerVariables);

			_browser.DocumentText = new YellowScreenOfDeathBuilder(error).GetHtml();
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

			_formsListView.ClearValues();
			_cookiesListView.ClearValues();
			_querystringListView.ClearValues();
			_serverVariablesListView.ClearValues();

			_browser.DocumentText = string.Empty;
		}
	}
}
