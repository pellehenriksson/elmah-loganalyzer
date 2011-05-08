using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Constants;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeDataSourceService : IDataSourceService
	{
		private readonly List<ErrorLog> _logs = new List<ErrorLog>();

		public FakeDataSourceService()
		{
			AddToLogs("System.InvalidOperationException", "some really serious error!", "Some.Namespace.Core", new DateTime(2011, 1, 1), "nisse", "some/path");
			AddToLogs("System.InvalidOperationException", string.Empty, "Some.Namespace.Data", new DateTime(2011, 1, 2), "kalle", "some/path");
			AddToLogs("System.SomeOtherException", string.Empty, "Some.Namespace.Domain", new DateTime(2011, 1, 3), "rulle", "some/other/path");
			AddToLogs("System.SomeOtherException", string.Empty, "Some.Namespace.Domain", new DateTime(2011, 1, 4), "rulle", "some/other/path");
		}
		
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
			errorLog.AddServerVariable(HttpServerVariables.LogonUser, user);
			errorLog.AddServerVariable(HttpServerVariables.Url, url);

			_logs.Add(errorLog);
		}
	}
}
