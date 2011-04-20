using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ReportQuery
	{
		public ReportQuery(ReportTypeEnum reportType, DateInterval interval)
		{
			ReportType = reportType;
			Interval = interval;
		}

		public ReportTypeEnum ReportType { get; private set; }

		public DateInterval Interval { get; private set; }
		
		public override string ToString()
		{
			return string.Format("{0} from {1} to {2}", ReportType.GetDescription(), Interval.StartDate.ToShortDateString(), Interval.EndDate.ToShortDateString());
		}
	}
}
