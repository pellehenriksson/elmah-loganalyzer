using System;

namespace Crepido.ElmahOfflineViewer.Core.Domain.Abstract
{
	public interface IReportGenerator
	{
		event EventHandler OnDataSourceInitialized;

		Report Create(ReportQuery query);
	}
}
