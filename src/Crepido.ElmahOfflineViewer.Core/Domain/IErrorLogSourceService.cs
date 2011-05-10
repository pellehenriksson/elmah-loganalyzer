using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface IErrorLogSourceService
	{
		List<ErrorLog> GetLogs(string directory);
	}
}
