using System;
using System.ComponentModel;

namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public static class EnumExtensions
	{
		public static string GetDescription(this Enum obj)
		{
			var fieldInfo = obj.GetType().GetField(obj.ToString());
			var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
			var description = (attributes.Length > 0) ? attributes[0].Description : obj.ToString();

			return !string.IsNullOrEmpty(description) ? description : obj.ToString();
		}
	}
}
