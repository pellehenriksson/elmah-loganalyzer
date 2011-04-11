using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class ReportPresenter
	{
		private readonly IReportView _view;
		private readonly IReportGenerator _generator;

		public ReportPresenter(IReportView view, IReportGenerator generator)
		{
			_view = view;
			_generator = generator;

			RegisterEvent();
		}

		public void Initialize()
		{
			_view.LoadReportTypes(BuildReportTypesList());
			_view.SetTimeInterval(DateTime.Today.AddDays(-7), DateTime.Today);
		}

		private void RegisterEvent()
		{
			_view.OnReportSelected += ViewOnReportSelected;
		}

		private void ViewOnReportSelected(object sender, ReportSelectionEventArgs e)
		{
			var report = _generator.Create(e.Query);
			_view.DisplayReport(report);
		}

		private List<ReportTypeListItem> BuildReportTypesList()
		{
			var list = new List<ReportTypeListItem>();

			list.Add(new ReportTypeListItem(ReportTypeEnum.Url));
			list.Add(new ReportTypeListItem(ReportTypeEnum.Type));
			list.Add(new ReportTypeListItem(ReportTypeEnum.Source));
			list.Add(new ReportTypeListItem(ReportTypeEnum.Day));
			list.Add(new ReportTypeListItem(ReportTypeEnum.User));

			return list;
		}
	}
}
