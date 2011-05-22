using System;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ErrorLogSearchEventArgs : EventArgs
	{
		public ErrorLogSearchEventArgs(SearchErrorLogQuery query)
		{
			Query = query;
		}

		public SearchErrorLogQuery Query { get; private set; }
	}
}
