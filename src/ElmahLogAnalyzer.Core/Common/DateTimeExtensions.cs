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

		public static string ToTruncatedString(this DateTime date)
		{
			var year = date.Year;
			var month = date.Month;
			var day = date.Day;
			var hour = date.Hour;
			var minute = date.Minute;

			return string.Format("{0}{1}{2}_{3}{4}", year, month, day, hour, minute);
		}
	}
}
