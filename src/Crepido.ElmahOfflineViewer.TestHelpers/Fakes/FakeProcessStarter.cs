using System;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeProcessStarter : IProcessStarter
	{
		public string RunWithUrl { get; private set; }

		public string RunWithArguments { get; set; }

		public void Run(string url)
		{
			RunWithUrl = url;
		}

		public void Run(string url, string arguments)
		{
			RunWithUrl = url;
			RunWithArguments = arguments;
		}
	}
}
