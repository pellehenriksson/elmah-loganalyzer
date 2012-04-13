using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public interface IDatabaseConnectionsHelper
	{
		DatabaseConnectionElementCollection GetConnections();

		List<string> GetNames(string type);

		DatabaseConnectionElement FindConnection(string name);
	}
}
