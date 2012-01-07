using System.Collections.Generic;
using System.Linq;

namespace ElmahLogAnalyzer.Core.Common
{
	public static class NameValuePairListExtensions
	{
		public static string GetValueFromFirstMatch(this List<NameValuePair> list, string name)
		{
			var match = list.FirstOrDefault(x => x.Name.ToLowerInvariant() == name.ToLowerInvariant());
			return match != null ? match.Value : string.Empty;
		} 
	}
}
