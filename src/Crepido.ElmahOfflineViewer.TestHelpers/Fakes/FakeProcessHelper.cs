using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeProcessHelper : IProcessHelper
	{
		public string RunWithUrl { get; private set; }

		public void Run(string url)
		{
			RunWithUrl = url;
		}
	}
}
