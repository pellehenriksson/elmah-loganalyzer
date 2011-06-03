using System;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeUrlPing : IUrlPing
	{
		private readonly bool _returnValue;
		private readonly string _returnMessage;

		public FakeUrlPing() : this(true, string.Empty)
		{
		}

		public FakeUrlPing(bool returnValue, string returnMessage)
		{
			_returnValue = returnValue;
			_returnMessage = returnMessage;
		}

		public Tuple<bool, string> Ping(NetworkConnection connection)
		{
			return new Tuple<bool, string>(_returnValue, _returnMessage);
		}
	}
}
