using System;

namespace ElmahLogAnalyzer.Core.Common
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

		public static DateInterval Create(DateIntervalSpans span, DateTime today)
		{
			switch (span)
			{
				case DateIntervalSpans.Week:
					return new DateInterval(today.AddDays(-7), today);
				case DateIntervalSpans.Month:
					return new DateInterval(today.AddMonths(-1), today);
				case DateIntervalSpans.Year:
					return new DateInterval(today.AddYears(-1), today);
			}

			return null;
		}
		
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public bool Equals(DateInterval other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}
			
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return other.StartDate.Equals(StartDate) && other.EndDate.Equals(EndDate);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (StartDate.GetHashCode() * 397) ^ EndDate.GetHashCode();
			}
		}

		public override string ToString()
		{
			return ToString(null);
		}

        public string ToString(IFormatProvider provider)
        {
            return string.Format(provider, "{0:d} {1:d}", StartDate, EndDate);
        }
	}
}
