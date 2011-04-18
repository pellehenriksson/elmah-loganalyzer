using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class ReportPresenter
	{
		private readonly IReportGenerator _generator;

		public ReportPresenter(IReportView view, IReportGenerator generator)
		{
			View = view;
			_generator = generator;

			RegisterEvents();
		}

		public IReportView View { get; private set; }

		public void Initialize()
		{
			View.LoadReportTypes(BuildReportTypesList());
			View.SetTimeInterval(DateTime.Today.AddDays(-7), DateTime.Today);
		}

		private void RegisterEvents()
		{
			View.OnReportSelected += ViewOnReportSelected;
		}

		private void ViewOnReportSelected(object sender, ReportSelectionEventArgs e)
		{
			var report = _generator.Create(e.Query);
			View.DisplayReport(report);
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
