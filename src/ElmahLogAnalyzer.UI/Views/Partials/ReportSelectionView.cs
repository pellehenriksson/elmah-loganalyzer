using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Views.Partials
{
	public partial class ReportSelectionView : UserControl
	{
		public ReportSelectionView()
		{
			InitializeComponent();
		}

		public event EventHandler<ReportSelectionEventArgs> OnReportSelected;

		public void SetDateInterval(DateInterval interval)
		{
			_dateIntervalPicker.SetInterval(interval);
		}

		public void LoadTypes(IEnumerable<ReportTypeListItem> types)
		{
			_reportsComboBox.Items.Clear();

			foreach (var item in types)
			{
				_reportsComboBox.Items.Add(item);
			}

			_reportsComboBox.SelectedIndex = 0;
		}

		public void LoadNumberOfResultsOptions(IEnumerable<NameValuePair> options)
		{
			_numberOfResultsComboBox.Items.Clear();

			foreach (var item in options)
			{
				_numberOfResultsComboBox.Items.Add(item);
			}

			_numberOfResultsComboBox.SelectedIndex = 0;
		}

		private void ShowButtonClick(object sender, EventArgs e)
		{
			if (OnReportSelected == null)
			{
				return;
			}

			var query = BuildQuery();
			OnReportSelected(this, new ReportSelectionEventArgs(query));
		}

		private ReportQuery BuildQuery()
		{
			var reportType = (ReportTypeListItem)_reportsComboBox.SelectedItem;
			var numberOfResults = Convert.ToInt32(((NameValuePair)_numberOfResultsComboBox.SelectedItem).Value);
			return new ReportQuery(reportType.ReportType, _dateIntervalPicker.GetInterval(), numberOfResults);
		}
	}
}
