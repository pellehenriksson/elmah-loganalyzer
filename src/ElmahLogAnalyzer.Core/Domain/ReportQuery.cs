using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Domain
{
    using System;

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
            return ToString(null);
        }

        public string ToString(IFormatProvider provider)
		{
			return string.Format(provider, "{0} from {1:d} to {2:d}", ReportType.GetDescription(), Interval.StartDate, Interval.EndDate);
		}
	}
}
