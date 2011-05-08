using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface IDataSourceService
	{
		List<ErrorLog> GetLogs(string directory);
	}
}
