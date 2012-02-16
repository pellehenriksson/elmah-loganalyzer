using System;
using System.Collections.Generic;
using System.Linq;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class ReportGenerator : IReportGenerator
	{
		private readonly IErrorLogRepository _repository;

		public ReportGenerator(IErrorLogRepository repository)
		{
			_repository = repository;
			_repository.OnInitialized += RepositoryOnInitialized;
		}

		public event EventHandler OnDataSourceInitialized;

		public Report Create(ReportQuery query)
		{
			var report = new Report(query);

			var filter = SearchErrorLogQuery.Create(query);
			var errors = _repository.GetWithFilter(filter);
			
			switch (query.ReportType)
			{
				case ReportTypes.Type:
					CreateByTypesReport(report, errors, query.NumberOfResults);
					break;
				case ReportTypes.Source:
					CreateBySourceReport(report, errors, query.NumberOfResults);
					break;
				case ReportTypes.User:
					CreateByUsersReport(report, errors, query.NumberOfResults);
					break;
				case ReportTypes.Url:
					CreateByUrlReport(report, errors, query.NumberOfResults);
					break;
				case ReportTypes.Day:
					CreateByDayReport(report, errors, query.NumberOfResults);
					break;
				case ReportTypes.Browser:
					CreateByBrowserReport(report, errors, query.NumberOfResults);
					break;
			}
			
			return report;
		}
		
		private static void CreateByTypesReport(Report report, IEnumerable<ErrorLog> errors, int numberOfResults)
		{
			var query = from e in errors
			        orderby e.Type
			        group e by e.Type
			        into g
			        select new ReportItem(g.Key, g.Count());

			report.AddRange(GetNumberOfResults(query, numberOfResults));
		}

		private static void CreateBySourceReport(Report report, IEnumerable<ErrorLog> errors, int numberOfResults)
		{
			var query = from e in errors
					orderby e.Source
					group e by e.Source
					into g
					select new ReportItem(g.Key, g.Count());

			report.AddRange(GetNumberOfResults(query, numberOfResults));
		}

		private static void CreateByUsersReport(Report report, IEnumerable<ErrorLog> errors, int numberOfResults)
		{
			var query = from e in errors
					orderby e.User
					group e by e.User
					into g
					select new ReportItem(g.Key, g.Count());

			report.AddRange(GetNumberOfResults(query, numberOfResults));
		}

		private static void CreateByUrlReport(Report report, IEnumerable<ErrorLog> errors, int numberOfResults)
		{
			var query = from e in errors
					orderby e.CleanUrl
					group e by e.CleanUrl
					into g
					select new ReportItem(g.Key, g.Count());

			report.AddRange(GetNumberOfResults(query, numberOfResults));
		}

		private static void CreateByDayReport(Report report, IEnumerable<ErrorLog> errors, int numberOfResults)
		{
			var query = from e in errors
					orderby e.Time.Date
					group e by e.Time.Date
					into g
					select new ReportItem(g.Key.ToShortDateString(), g.Count());

			report.AddRange(GetNumberOfResults(query, numberOfResults));
		}

		private static void CreateByBrowserReport(Report report, IEnumerable<ErrorLog> errors, int numberOfResults)
		{
			var query = from e in errors
			            orderby e.ClientInformation.Browser
			            group e by e.ClientInformation.Browser
			            into g
						select new ReportItem(g.Key, g.Count());

			report.AddRange(GetNumberOfResults(query, numberOfResults));
		}

		private static IEnumerable<ReportItem> GetNumberOfResults(IEnumerable<ReportItem> items, int numberOfResults)
		{
			var result = numberOfResults == -1 ? items.ToList() : items.OrderByDescending(x => x.Count).ToList().Take(numberOfResults);
			return result;
		}

		private void RepositoryOnInitialized(object sender, RepositoryInitializedEventArgs e)
		{
			if (OnDataSourceInitialized != null)
			{
				OnDataSourceInitialized(this, new EventArgs());
			}
		}
	}
}
