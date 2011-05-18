using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeUrlPing : IUrlPing
	{
		private readonly bool _returnValue;

		public FakeUrlPing() : this(true)
		{
		}

		public FakeUrlPing(bool returnValue)
		{
			_returnValue = returnValue;
		}

		public bool Ping(string url)
		{
			return _returnValue;
		}
	}
}
