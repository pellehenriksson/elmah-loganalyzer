using System.Windows.Forms;

namespace Crepido.ElmahOfflineViewer.UI.Views
{
	public partial class MainView : UserControl
	{
		public MainView(SearchView searchView, ReportView reportView)
		{
			InitializeComponent();
			
			_searchTabPage.Controls.Add(searchView);
			_reportTabPage.Controls.Add(reportView);
		}
	}
}
