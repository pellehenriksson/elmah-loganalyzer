using System;
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
	}
}
