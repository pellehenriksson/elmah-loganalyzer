using System;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;

namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	public partial class SearchDetailsView : UserControl
	{
		public SearchDetailsView()
		{
			InitializeComponent();
			_httpUserAgentStringSearckLinkLabel.Visible = false;
		}

		public event EventHandler<SearchHttpUserAgentInformationEventArgs> OnSearchHttpUserAgentInformationClicked;

		private ErrorLog ErrorLog { get; set; }

		public void DisplayError(ErrorLog error)
		{
			ErrorLog = error;

			Clear();

			_timeLabel.Text = ErrorLog.Time.ToString();
			_typeLabel.Text = ErrorLog.Type;
			_sourceLabel.Text = ErrorLog.Source;
			_userLabel.Text = ErrorLog.User;
			_messageTextBox.Text = ErrorLog.Message;
			_detailsTextBox.Text = ErrorLog.Details;

			_urlLabel.Text = ErrorLog.Url;
			_platformLabel.Text = ErrorLog.ClientInformation.Platform;
			_operatingSystemLabel.Text = ErrorLog.ClientInformation.OperatingSystem;
			_browserLabel.Text = ErrorLog.ClientInformation.Browser;
			_ipAddressLabel.Text = ErrorLog.LocalIpAddress;
			_descriptionLabel.Text = ErrorLog.ClientInformation.Description;
			_httpUserAgentStringSearckLinkLabel.Visible = true;

			_formsListView.LoadValues(ErrorLog.FormValues);
			_cookiesListView.LoadValues(ErrorLog.Cookies);
			_querystringListView.LoadValues(ErrorLog.QuerystringValues);
			_serverVariablesListView.LoadValues(ErrorLog.ServerVariables);

			_browser.DocumentText = new YellowScreenOfDeathBuilder(ErrorLog).GetHtml();
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
			_descriptionLabel.Text = string.Empty;
			_httpUserAgentStringSearckLinkLabel.Visible = false;

			_formsListView.ClearValues();
			_cookiesListView.ClearValues();
			_querystringListView.ClearValues();
			_serverVariablesListView.ClearValues();

			_browser.DocumentText = string.Empty;
		}

		private void HttpUserAgentStringSearckLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (OnSearchHttpUserAgentInformationClicked != null)
			{
				OnSearchHttpUserAgentInformationClicked(this, new SearchHttpUserAgentInformationEventArgs(ErrorLog.ClientInformation.HttpUserAgentString));
			}
		}
	}
}
