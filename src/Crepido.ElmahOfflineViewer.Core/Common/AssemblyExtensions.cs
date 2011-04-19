using System;
using System.Linq;
using System.Reflection;

namespace Crepido.ElmahOfflineViewer.Core.Common
{
	public static class AssemblyExtensions
	{
		public static string GetTypeOfBuild(this Assembly assembly)
		{
			return assembly.GetCustomAttributes(false)
					.Where(attribute => attribute.GetType() == Type.GetType("System.Diagnostics.DebuggableAttribute"))
					.Any(attribute => ((System.Diagnostics.DebuggableAttribute) attribute).IsJITTrackingEnabled) ? "Debug" : "Release";
		}
	}
}
