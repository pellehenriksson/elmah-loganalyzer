using System;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
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
