using System.Drawing;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	public partial class ReportChartView : UserControl
	{
		private Report _report;

		public ReportChartView()
		{
			InitializeComponent();
		}

		public void DisplayReport(Report report)
		{
			_report = report;

			ClearView();
			SetTitle();
			SetSeries();
		}
		
		public void ClearView()
		{
			_chart.Titles.Clear();
			_chart.Series.Clear();
		}

		private void SetTitle()
		{
			var title = _chart.Titles.Add("default");
			title.Text = _report.Query.ToString();
			title.Alignment = ContentAlignment.TopLeft;
			title.Font = GetFont(12);
		}

		private void SetSeries()
		{
			var serie = _chart.Series.Add("default");
			serie.Font = GetFont(10);
			
			foreach (var item in _report.Items)
			{
				serie.Points.AddXY(item.Key, item.Count);
				serie.IsValueShownAsLabel = true;
			}
		}
		
		private Font GetFont(float size)
		{
			return new Font("Consolas", size, FontStyle.Bold);
		}
	}
}
