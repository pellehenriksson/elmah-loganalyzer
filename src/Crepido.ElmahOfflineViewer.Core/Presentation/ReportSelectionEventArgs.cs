using System;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
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
