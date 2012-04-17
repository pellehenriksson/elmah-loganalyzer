using System;
using System.IO;
using System.Linq;
using CassiniDev;

namespace ElmahLogAnalyzer.TestHelpers
{
	public class TestWebServer : CassiniDevServer, IDisposable
	{
		public static readonly string Url = "http://localhost:8099/elmah.axd";

		public TestWebServer()
		{
			var path = GetWebProjectPath();
			StartServer(path, 8099, "/", "localhost");
		}

		public new void Dispose()
		{
			StopServer();
			base.Dispose();
		}
		
		private static string GetWebProjectPath()
		{
			var webproject = "ElmahWeb";

			var currentDir = Directory.GetCurrentDirectory();
			var temp = new DirectoryInfo(currentDir);

			while (ContainsDirectory(temp, webproject) == false)
			{
				temp = temp.Parent;
			}

			var webprojectPath = Path.Combine(temp.FullName, webproject);
			return webprojectPath;
		}

		private static bool ContainsDirectory(DirectoryInfo current, string dirToFind)
		{
			var subDirectories = current.GetDirectories();
			return subDirectories.Any(dir => dir.Name == dirToFind);
		}
	}
}
