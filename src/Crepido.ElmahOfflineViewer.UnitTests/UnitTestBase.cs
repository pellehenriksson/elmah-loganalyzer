using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.UnitTests
{
	public abstract class UnitTestBase
	{
		public string FakeLogsDirectory
		{
			get { return @"c:\logs"; }
		}

		public ReportQuery CreateReportQuery()
		{
			return new ReportQuery(ReportTypeEnum.Type, new DateTime(1975, 5, 14), new DateTime(2011, 4, 8));
		}

		public List<ErrorLog> CreateErrorLogs()
		{
			var result = new List<ErrorLog>();

			result.Add(new ErrorLog("System.InvalidOperationException", "Some.Namespace.Core", new DateTime(2011, 1, 1), "nisse", "some/path"));
			result.Add(new ErrorLog("System.InvalidOperationException", "Some.Namespace.Data", new DateTime(2011, 1, 2), "kalle", "some/path"));
			result.Add(new ErrorLog("System.SomeOtherException", "Some.Namespace.Domain", new DateTime(2011, 1, 3), "rulle", "some/other/path"));
			result.Add(new ErrorLog("System.SomeOtherException", "Some.Namespace.Domain", new DateTime(2011, 1, 4), "rulle", "some/other/path"));

			return result;
		}
	}
}
