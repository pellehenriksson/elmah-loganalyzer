using System;

namespace ElmahLogAnalyzer.Core.Common
{
	public static class DateTimeExtensions
	{
		public static bool IsBetween(this DateTime source, DateTime startDate, DateTime endDate)
		{
			return source >= startDate && source <= endDate;
		}

		public static bool IsBetween(this DateTime source, DateInterval interval)
		{
			if (interval == null)
			{
				throw new ArgumentNullException("interval");	
			}

			return source.IsBetween(interval.StartDate, interval.EndDate);
		}
	}
}
