using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
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

		private static IEnumerable<ReportTypeListItem> BuildReportTypesList()
		{
			var list = new List<ReportTypeListItem>();

			list.Add(new ReportTypeListItem(ReportTypeEnum.Url));
			list.Add(new ReportTypeListItem(ReportTypeEnum.Type));
			list.Add(new ReportTypeListItem(ReportTypeEnum.Source));
			list.Add(new ReportTypeListItem(ReportTypeEnum.Day));
			list.Add(new ReportTypeListItem(ReportTypeEnum.User));
			list.Add(new ReportTypeListItem(ReportTypeEnum.Browser));

			return list;
		}

		private static IEnumerable<NameValuePair> BuildNumerOfResultsOptionsList()
		{
			var list = new List<NameValuePair>();

			list.Add(new NameValuePair("ALL", "-1"));
			list.Add(new NameValuePair("TOP 500", "500"));
			list.Add(new NameValuePair("TOP 100", "100"));
			list.Add(new NameValuePair("TOP 50", "50"));
			list.Add(new NameValuePair("TOP 10", "10"));
			
			return list;
		}

		private void RegisterEvents()
		{
			View.OnLoaded += ViewOnLoaded;
			View.OnReportSelected += ViewOnReportSelected;
			_generator.OnDataSourceInitialized += GeneratorOnDataSourceInitialized;
		}
		
		private void Initialize()
		{
			View.LoadReportTypes(BuildReportTypesList());
			View.LoadNumberOfResultsOptions(BuildNumerOfResultsOptionsList());

			var interval = DateInterval.Create(DateIntervalSpanEnum.Week, DateTime.Today);
			View.SetDateInterval(interval);
		}

		private void ViewOnLoaded(object sender, EventArgs e)
		{
			Initialize();
		}

		private void ViewOnReportSelected(object sender, ReportSelectionEventArgs e)
		{
			var report = _generator.Create(e.Query);
			View.DisplayReport(report);
		}

		private void GeneratorOnDataSourceInitialized(object sender, EventArgs e)
		{
			View.Clear();
		}
	}
}
