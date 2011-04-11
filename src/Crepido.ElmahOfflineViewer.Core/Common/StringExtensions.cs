namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public static class StringExtensions
	{
		public static bool HasValue(this string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}
	}
}
