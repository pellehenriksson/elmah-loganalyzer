using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class SearchErrorLogQuery
	{
		public SearchErrorLogQuery()
		{
			Types = new SearchErrorLogQueryParameter();
			Sources = new SearchErrorLogQueryParameter();
			Users = new SearchErrorLogQueryParameter();
			Urls  = new SearchErrorLogQueryParameter();
		}

		public SearchErrorLogQueryParameter Types { get; set; }

		public SearchErrorLogQueryParameter Sources { get; set; }

		public SearchErrorLogQueryParameter Users { get; set; }

		public SearchErrorLogQueryParameter Urls { get; set; }
		
		public DateInterval Interval { get; set; }

		public string Text { get; set; }

		public static SearchErrorLogQuery Create(ReportQuery reportQuery)
		{
			var query = new SearchErrorLogQuery { Interval = reportQuery.Interval };
			return query;
		}
	}
}
