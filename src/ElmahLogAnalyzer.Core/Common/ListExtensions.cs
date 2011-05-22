using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Common
{
	public static class ListExtensions
	{
		public static bool InvertedContains(this List<string> list, string item, bool include)
		{
			if (include)
			{
				return list.Contains(item);
			}

			return !list.Contains(item);
		}
	}
}
