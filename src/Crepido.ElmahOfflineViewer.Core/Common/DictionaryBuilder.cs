using System;
using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public static class DictionaryBuilder
	{
		private const int KeyIndex = 0;
		private const int ValueIndex = 1;

		public static Dictionary<string, string> BuildFromText(string text, char valueSplitChar = ';', char keyValueSplitChar = '=')
		{
			if (text == null)
			{
				throw new ArgumentNullException("text");
			}

			var result = new Dictionary<string, string>();

			if (!text.HasValue())
			{
				return result;
			}

			var valueList = text.Split(valueSplitChar);
	
			foreach (var listValue in valueList)
			{
				var item = listValue.Split(keyValueSplitChar);

				var key = item[KeyIndex];
				var value = string.Empty;

				if (item.Length > 1)
				{
					value = item[ValueIndex];
				}
				
				result.Add(key, value);
			}

			return result;
		}
	}
}
