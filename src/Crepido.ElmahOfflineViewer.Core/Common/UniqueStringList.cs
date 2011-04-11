using System.Collections.Generic;
using System.Linq;

namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public class UniqueStringList
	{
		private readonly SortedList<string, string> _list = new SortedList<string, string>();

		public List<string> List
		{
			get { return _list.Values.ToList(); }
		}

		public void Add(string item)
		{
			if (!item.HasValue())
			{
				return;
			}

			if (_list.ContainsKey(item))
			{
				return;
			}

			_list.Add(item, item);
		}

		public void Clear()
		{
			_list.Clear();
		}
	}
}
