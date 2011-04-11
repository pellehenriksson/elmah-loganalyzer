using System;
using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ReportQuery
	{
		public ReportQuery(ReportTypeEnum reportType, DateTime startTime, DateTime endTime)
		{
			ReportType = reportType;
			StartTime = startTime;
			EndTime = endTime;
		}

		public ReportTypeEnum ReportType { get; private set; }

		public DateTime StartTime { get; private set; }

		public DateTime EndTime { get; private set; }

		public override string ToString()
		{
			return string.Format("{0} from {1} to {2}", ReportType.GetDescription(), StartTime.ToShortDateString(), EndTime.ToShortDateString());
		}
	}
}
