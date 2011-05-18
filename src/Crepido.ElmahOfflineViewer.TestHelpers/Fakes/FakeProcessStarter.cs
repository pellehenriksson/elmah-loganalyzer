using System;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeProcessStarter : IProcessStarter
	{
		public Uri RunWithUrl { get; private set; }

		public string RunWithArguments { get; set; }

		public void Run(Uri url)
		{
			RunWithUrl = url;
		}

		public void Run(Uri url, string arguments)
		{
			RunWithUrl = url;
			RunWithArguments = arguments;
		}
	}
}
