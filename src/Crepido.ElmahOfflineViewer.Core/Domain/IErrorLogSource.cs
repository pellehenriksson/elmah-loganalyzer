using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface IErrorLogSource
	{
		string Path { get; }

		List<ErrorLog> GetLogs(string directory);
	}
}
