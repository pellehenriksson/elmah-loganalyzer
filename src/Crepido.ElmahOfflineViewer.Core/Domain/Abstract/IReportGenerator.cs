namespace Crepido.ElmahOfflineViewer.Core.Domain.Abstract
{
	public interface IReportGenerator
	{
		Report Create(ReportQuery query);
	}
}
