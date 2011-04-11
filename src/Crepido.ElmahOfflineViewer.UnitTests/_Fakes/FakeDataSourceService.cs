using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;

namespace Crepido.ElmahOfflineViewer.UnitTests._Fakes
{
	public class FakeDataSourceService : IDataSourceService
	{
		private readonly List<ErrorLog> _logs = new List<ErrorLog>();

		public FakeDataSourceService()
		{
			_logs.Add(new ErrorLog("System.InvalidOperationException", "Some.Namespace.Core", new DateTime(2011, 1, 1), "nisse", "some/path"));
			_logs.Add(new ErrorLog("System.InvalidOperationException", "Some.Namespace.Data", new DateTime(2011, 1, 2), "kalle", "some/path"));
			_logs.Add(new ErrorLog("System.SomeOtherException", "Some.Namespace.Domain", new DateTime(2011, 1, 3), "rulle", "some/other/path"));
			_logs.Add(new ErrorLog("System.SomeOtherException", "Some.Namespace.Domain", new DateTime(2011, 1, 4), "rulle", "some/other/path"));
		}

		public List<ErrorLog> GetLogs(string directory)
		{
			return _logs;
		}
	}
}
