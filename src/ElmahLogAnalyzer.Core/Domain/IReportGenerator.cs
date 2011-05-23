using System;

namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IReportGenerator
	{
		event EventHandler OnDataSourceInitialized;

		Report Create(ReportQuery query);
	}
}
