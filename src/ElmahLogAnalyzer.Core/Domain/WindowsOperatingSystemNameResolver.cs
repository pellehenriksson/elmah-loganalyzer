using System.Collections.Generic;
using System.Linq;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Domain
{
	public static class WindowsOperatingSystemNameResolver
	{
		private static readonly Dictionary<string, string> OperatingSystems = new Dictionary<string, string>();

		static WindowsOperatingSystemNameResolver()
		{
			OperatingSystems.Add("95", "Windows 95");
			OperatingSystems.Add("98", "Windows 98");
			OperatingSystems.Add("NT 4.0", "Windows NT 4.0");
			OperatingSystems.Add("NT 5.0", "Windows 2000");
			OperatingSystems.Add("NT 5.1", "Windows XP");
			OperatingSystems.Add("NT 5.2", "Windows Server 2003");
			OperatingSystems.Add("NT 6.0", "Windows Vista");
			OperatingSystems.Add("NT 6.1", "Windows 7");
			OperatingSystems.Add("NT 6.2", "Windows 8");
		}

		public static string Resolve(string version)
		{
			foreach (var os in OperatingSystems.Where(os => version.ContainsText(os.Key, true)))
			{
				return os.Value;
			}

			return version;
		}
	}
}
