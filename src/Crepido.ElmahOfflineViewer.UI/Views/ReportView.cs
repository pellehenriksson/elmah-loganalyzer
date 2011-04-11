using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;

namespace Crepido.ElmahOfflineViewer.UI.Views
{
	public partial class ReportView : UserControl, IReportView
	{
		public ReportView()
		{
			InitializeComponent();

			_selectionView.OnReportSelected += SelectionViewOnReportSelected;
		}

		public event EventHandler<ReportSelectionEventArgs> OnReportSelected;

		public void LoadReportTypes(List<ReportTypeListItem> types)
		{
			_selectionView.LoadTypes(types);
		}

		public void SetTimeInterval(DateTime startTime, DateTime endTime)
		{
			_selectionView.SetTimeInterval(startTime, endTime);
		}

		public void DisplayReport(Report report)
		{
			_chartView.DisplayReport(report);
		}
		
		private void SelectionViewOnReportSelected(object sender, ReportSelectionEventArgs e)
		{
			OnReportSelected(this, e);
		}
	}
}
