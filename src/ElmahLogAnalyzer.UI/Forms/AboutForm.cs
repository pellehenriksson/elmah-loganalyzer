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
			Process.Start("http://code.google.com/p/elmah-loganalyzer");
		}

		private void SilkLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.famfamfam.com/lab/icons/silk");
		}

		private void NinjecLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://ninject.org");
		}

		private void NLogLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://nlog-project.org");
		}

		private void DapperLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://code.google.com/p/dapper-dot-net/");
		}
	}
}
