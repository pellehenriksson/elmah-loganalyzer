namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public static class StringExtensions
	{
		public static bool HasValue(this string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}

		public static bool ContainsText(this string value, string part, bool caseInsensitive = false)
		{
			if (!value.HasValue())
			{
				return false;
			}

			if (caseInsensitive)
			{
				return value.ToLowerInvariant().Contains(part.ToLowerInvariant());
			}

			return value.Contains(part);
		}
	}
}
