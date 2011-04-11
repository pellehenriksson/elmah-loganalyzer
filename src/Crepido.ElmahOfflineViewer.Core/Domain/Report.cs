using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class Report
	{
		public Report(ReportQuery query)
		{
			Query = query;
			Items = new List<ReportItem>();
		}

		public ReportQuery Query { get; private set; }
		
		public List<ReportItem> Items { get; private set; }

		public void AddRange(List<ReportItem> items)
		{
			Items.AddRange(items);
		}
	}
}
