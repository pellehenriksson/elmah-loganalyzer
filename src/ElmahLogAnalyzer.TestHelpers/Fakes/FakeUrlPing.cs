using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
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

		public bool Ping(NetworkConnection connection)
		{
			return _returnValue;
		}
	}
}
