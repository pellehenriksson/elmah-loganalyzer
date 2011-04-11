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

			SetTitle();
			SetSeries();
		}

		private void SetTitle()
		{
			_chart.Titles.Clear();

			var title = _chart.Titles.Add("default");
			title.Text = _report.Query.ToString();
			title.Alignment = ContentAlignment.TopLeft;
		}

		private void SetSeries()
		{
			_chart.Series.Clear();

			var serie = _chart.Series.Add("default");

			foreach (var item in _report.Items)
			{
				serie.Points.AddXY(item.Key, item.Count);
				serie.IsValueShownAsLabel = true;
			}
		}
	}
}
