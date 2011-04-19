using System;

namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public class DateInterval
	{
		public DateInterval(DateTime startDate, DateTime endDate)
		{
			StartDate = startDate;
			EndDate = endDate;
		}

		public DateTime StartDate { get; private set; }

		public DateTime EndDate { get; private set; }
	}
}
