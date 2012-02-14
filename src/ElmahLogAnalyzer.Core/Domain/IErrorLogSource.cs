using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IErrorLogSource
	{
		string Connection { get; }

		List<ErrorLog> GetLogs();
	}
}
