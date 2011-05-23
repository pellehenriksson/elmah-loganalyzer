using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IErrorLogSource
	{
		string Path { get; }

		List<ErrorLog> GetLogs(string directory);
	}
}
