using System;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ReportSelectionEventArgs : EventArgs
	{
		public ReportSelectionEventArgs(ReportQuery query)
		{
			Query = query;
		}
		
		public ReportQuery Query { get; private set; }
	}
}
