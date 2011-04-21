using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Common;
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

			selectionView.OnReportSelected += SelectionViewOnReportSelected;
		}

		public event EventHandler OnLoaded;

		public event EventHandler<ReportSelectionEventArgs> OnReportSelected;

		public void LoadReportTypes(List<ReportTypeListItem> types)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x.selectionView.LoadTypes(types));
			}
			else
			{
				selectionView.LoadTypes(types);
			}
		}

		public void SetDateInterval(DateInterval interval)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x.selectionView.SetDateInterval(interval));
			}
			else
			{
				selectionView.SetDateInterval(interval);
			}
		}

		public void DisplayReport(Report report)
		{
			chartView.DisplayReport(report);
		}

		public void Clear()
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x.chartView.ClearView());
			}
			else
			{
				chartView.ClearView();
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
