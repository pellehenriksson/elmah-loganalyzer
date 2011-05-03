using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Presentation.Abstract
{
	public interface IReportView
	{
		event EventHandler OnLoaded;

		event EventHandler<ReportSelectionEventArgs> OnReportSelected;

		void LoadReportTypes(IEnumerable<ReportTypeListItem> types);

		void SetDateInterval(DateInterval interval);

		void DisplayReport(Report report);

		void Clear();
	}
}
