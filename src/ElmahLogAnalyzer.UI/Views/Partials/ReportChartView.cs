using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.UI.Views.Partials
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
			BuildChart();
		}
		
		public void ClearView()
		{
			Controls.Clear();
		}

		private static Font GetFont(float size)
		{
			return new Font("Microsoft Sans Serif", size, FontStyle.Bold);
		}

		private void BuildChart()
		{
			var area = new ChartArea();
			area.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
			area.AxisX.IsLabelAutoFit = false;
			area.AxisX.LabelStyle.Angle = -90;
			area.AxisX.LabelStyle.Interval = 0D;
			area.AxisX.TitleFont = GetFont(10);
			area.AxisY.TitleFont = GetFont(10);
			area.Name = "default";
			area.AxisY.Title = "Number of errors";

			var chart = new Chart { Dock = DockStyle.Fill };

			chart.ChartAreas.Add(area);

			SetTitle(chart);
			SetSeries(chart);

			Controls.Add(chart);
		}
		
		private void SetTitle(Chart chart)
		{
			var title = chart.Titles.Add("default");
			title.Text = _report.Query.ToString();
			title.Alignment = ContentAlignment.TopLeft;
			title.Font = GetFont(12);
		}

		private void SetSeries(Chart chart)
		{
			var serie = chart.Series.Add("default");
			serie.Font = GetFont(10);

			foreach (var item in _report.Items)
			{
				serie.Points.AddXY(item.Key, item.Count);
				serie.IsValueShownAsLabel = true;
			}
		}
	}
}
