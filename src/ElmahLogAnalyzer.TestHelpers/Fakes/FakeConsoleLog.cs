using System;
using ElmahLogAnalyzer.Core.Infrastructure.Logging;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeConsoleLog : ILog
	{
		public void Debug(string message)
		{
			Console.WriteLine(@"DEBUG: " + message);
		}

		public void Error(string message)
		{
			Console.WriteLine(@"ERROR: " + message);
		}

		public void Error(string message, Exception exception)
		{
			throw new NotImplementedException();
		}

		public void Error(Exception exception)
		{
			throw new NotImplementedException();
		}
	}
}
