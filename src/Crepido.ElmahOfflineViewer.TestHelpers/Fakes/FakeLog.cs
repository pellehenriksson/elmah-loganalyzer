using System;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
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
