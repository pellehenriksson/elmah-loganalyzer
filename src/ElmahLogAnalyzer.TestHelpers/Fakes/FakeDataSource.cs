using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Constants;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeDataSource : IErrorLogSource
	{
		private readonly List<ErrorLog> _logs = new List<ErrorLog>();

		public FakeDataSource()
		{
			AddToLogs("System.InvalidOperationException", "some really serious error!", "Some.Namespace.Core", new DateTime(2011, 1, 1), "nisse", "some/path");
			AddToLogs("System.InvalidOperationException", string.Empty, "Some.Namespace.Data", new DateTime(2011, 1, 2), "kalle", "some/path");
			AddToLogs("System.SomeOtherException", string.Empty, "Some.Namespace.Domain", new DateTime(2011, 1, 3), "rulle", "some/other/path");
			AddToLogs("System.SomeOtherException", string.Empty, "Some.Namespace.Domain", new DateTime(2011, 1, 4), "rulle", "some/other/path");
			AddToLogs("System.Exception", string.Empty, "Some.NamespaceOther.Domain", new DateTime(2011, 1, 4), null, null);
		}

		public string Path { get; set; }

		public List<ErrorLog> GetLogs(string directory)
		{
			return _logs;
		}
		
		private void AddToLogs(string type, string message, string source, DateTime time, string user, string url)
		{
			var errorLog = new ErrorLog();
			
			errorLog.ErrorId = Guid.NewGuid().ToString();
			errorLog.Type = type;
			errorLog.Message = message;
			errorLog.Source = source;
			errorLog.Time = time;

			if (user.HasValue())
			{
				errorLog.AddServerVariable(HttpServerVariables.LogonUser, user);
			}

			if (url.HasValue())
			{
				errorLog.AddServerVariable(HttpServerVariables.Url, url);
			}

			_logs.Add(errorLog);
		}
	}
}
