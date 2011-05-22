using System.Diagnostics;
using System.Windows.Forms;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			CancelButton = _closeButton;
		}
		
		private void UpdateLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://code.google.com/p/elmahofflineviewer/");
		}

		private void ThanksLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.famfamfam.com/lab/icons/silk/");
		}
	}
}
