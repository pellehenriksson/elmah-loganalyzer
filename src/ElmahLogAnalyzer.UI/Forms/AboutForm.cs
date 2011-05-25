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
		
		private static void UpdateLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://code.google.com/p/elmahofflineviewer/");
		}

		private static void SilkLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.famfamfam.com/lab/icons/silk/");
		}

		private static void NinjecLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://ninject.org/");
		}

		private static void NLogLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://nlog-project.org/");
		}
	}
}
