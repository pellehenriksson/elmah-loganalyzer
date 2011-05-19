using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class SearchErrorLogQueryParameter
	{
		public SearchErrorLogQueryParameter()
		{
			Items = new List<string>();
		}

		public SearchErrorLogQueryParameter(bool includeItems, List<string> items)
		{
			IncludeItems = includeItems;
			Items = items;
		}

		public bool IncludeItems { get; set; }

		public List<string> Items { get; private set; }
	}
}
