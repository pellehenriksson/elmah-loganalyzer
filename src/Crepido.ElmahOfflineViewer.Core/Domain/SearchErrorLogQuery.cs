using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class SearchErrorLogQuery
	{
		public string Type { get; set; }

		public string Source { get; set; }
		
		public string User { get; set; }
		
		public string Text { get; set; }

		public string Url { get; set; }
		
		public DateInterval Interval { get; set; }
		
		public static SearchErrorLogQuery Create(ReportQuery reportQuery)
		{
			var query = new SearchErrorLogQuery { Interval = reportQuery.Interval };
			return query;
		}
	}
}
