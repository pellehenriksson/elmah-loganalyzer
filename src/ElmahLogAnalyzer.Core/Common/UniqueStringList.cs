using System.Collections.Generic;
using System.Linq;

namespace ElmahLogAnalyzer.Core.Common
{
	public class UniqueStringList
	{
		private readonly SortedList<string, string> _list = new SortedList<string, string>();

		public UniqueStringList()
		{
		}

		public UniqueStringList(bool allowEmptyValue)
		{
			AllowEmptyValue = allowEmptyValue;
		}
		
		public List<string> List
		{
			get { return _list.Values.ToList(); }
		}
		
		private bool AllowEmptyValue { get; set; }

		public void Add(string item)
		{
			if (AllowEmptyValue)
			{
				if (item == null)
				{
					return;
				}
			}
			else
			{
				if (!item.HasValue())
				{
					return;
				}
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
