using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IErrorLogSource
	{
		List<ErrorLog> GetLogs(string directory);
	}
}
