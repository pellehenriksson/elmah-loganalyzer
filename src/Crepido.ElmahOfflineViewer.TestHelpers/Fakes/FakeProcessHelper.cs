using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeProcessHelper : IProcessHelper
	{
		public string Url { get; private set; }

		public void Start(string url)
		{
			Url = url;
		}
	}
}
