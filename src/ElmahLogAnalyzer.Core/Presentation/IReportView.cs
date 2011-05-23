using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
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
