using System;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class ErrorLogSelectedEventArgs : EventArgs
	{
		public ErrorLogSelectedEventArgs(ErrorLog errorLog)
		{
			ErrorLog = errorLog;
		}

		public ErrorLog ErrorLog { get; private set; }
	}
}
