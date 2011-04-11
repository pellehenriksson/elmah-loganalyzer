using System;

namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public static class DateTimeExtensions
	{
		public static bool IsBetween(this DateTime source, DateTime startDate, DateTime endDate)
		{
			return source >= startDate && source <= endDate;
		}
	}
}
