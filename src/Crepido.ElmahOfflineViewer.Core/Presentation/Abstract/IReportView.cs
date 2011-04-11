using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Presentation.Abstract
{
	public interface IReportView
	{
		event EventHandler<ReportSelectionEventArgs> OnReportSelected;

		void LoadReportTypes(List<ReportTypeListItem> types);

		void SetTimeInterval(DateTime startTime, DateTime endTime);

		void DisplayReport(Report report);
	}
}
