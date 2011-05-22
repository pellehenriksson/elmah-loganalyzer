using System;
using ElmahLogAnalyzer.Core.Infrastructure;
using ElmahLogAnalyzer.Core.Infrastructure.Logging;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeLog : ILog
	{
		public void Debug(string message)
		{
		}

		public void Error(string message)
		{
		}

		public void Error(string message, Exception exception)
		{
		}

		public void Error(Exception exception)
		{
		}
	}
}
