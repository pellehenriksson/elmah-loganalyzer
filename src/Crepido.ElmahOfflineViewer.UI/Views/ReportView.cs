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

		public event EventHandler OnLoaded;

		public event EventHandler<ReportSelectionEventArgs> OnReportSelected;

		public void LoadReportTypes(List<ReportTypeListItem> types)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x._selectionView.LoadTypes(types));
			}
			else
			{
				_selectionView.LoadTypes(types);
			}
		}

		public void SetTimeInterval(DateTime startTime, DateTime endTime)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x._selectionView.SetTimeInterval(startTime, endTime));
			}
			else
			{
				_selectionView.SetTimeInterval(startTime, endTime);
			}
		}

		public void DisplayReport(Report report)
		{
			_chartView.DisplayReport(report);
		}

		public void Clear()
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x._chartView.ClearView());
			}
			else
			{
				_chartView.ClearView();
			}
		}

		private void SelectionViewOnReportSelected(object sender, ReportSelectionEventArgs e)
		{
			OnReportSelected(this, e);
		}

		private void ReportViewLoad(object sender, EventArgs e)
		{
			if (OnLoaded != null)
			{
				OnLoaded(this, new EventArgs());
			}
		}
	}
}
