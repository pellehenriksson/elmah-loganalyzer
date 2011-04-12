namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public static class StringExtensions
	{
		public static bool HasValue(this string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}

		public static bool ContainsText(this string value, string part)
		{
			if (!value.HasValue())
			{
				return false;
			}

			return value.Contains(part);
		}
	}
}
