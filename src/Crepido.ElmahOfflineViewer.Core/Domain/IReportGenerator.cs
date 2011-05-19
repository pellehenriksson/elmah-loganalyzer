using System;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface IReportGenerator
	{
		event EventHandler OnDataSourceInitialized;

		Report Create(ReportQuery query);
	}
}
