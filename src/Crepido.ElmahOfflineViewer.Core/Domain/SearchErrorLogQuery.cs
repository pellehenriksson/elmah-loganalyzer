using System;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class SearchErrorLogQuery
	{
		public string Type { get; set; }

		public string Source { get; set; }
		
		public string User { get; set; }
		
		public string Text { get; set; }
		
		public DateTime StartTime { get; set; }
		
		public DateTime EndTime { get; set; }

		public static SearchErrorLogQuery Create(ReportQuery reportQuery)
		{
			var query = new SearchErrorLogQuery { StartTime = reportQuery.StartTime, EndTime = reportQuery.EndTime };
			return query;
		}
	}
}
