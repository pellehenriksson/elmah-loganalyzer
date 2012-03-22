using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Domain
{
    using System;

    public class ReportQuery
	{
		public ReportQuery(string application, ReportTypes reportType, DateInterval interval, int numberOfResults)
		{
			Application = application;
			ReportType = reportType;
			Interval = interval;
			NumberOfResults = numberOfResults;
		}

    	public string Application { get; private set; }

		public ReportTypes ReportType { get; private set; }

		public DateInterval Interval { get; private set; }

    	public int NumberOfResults { get; set; }

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
