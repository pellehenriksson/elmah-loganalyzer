using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
    using System;

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

		public bool Ping(Uri url)
		{
			return _returnValue;
		}
	}
}
