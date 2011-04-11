using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain.Abstract
{
	public interface IDataSourceService
	{
		List<ErrorLog> GetLogs(string directory);
	}
}
