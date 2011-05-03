using System;
using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class Report
	{
		public Report(ReportQuery query)
		{
			if (query == null)
			{
				throw new ArgumentNullException("query");
			}

			Query = query;
			Items = new List<ReportItem>();
		}

		public ReportQuery Query { get; private set; }
		
		public List<ReportItem> Items { get; private set; }

		public void AddRange(IEnumerable<ReportItem> items)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");	
			}

			Items.AddRange(items);
		}
	}
}
