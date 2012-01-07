using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public interface IWebServerConnectionsHelper
	{
		WebServerConnectionElementCollection GetConnections();

		List<string> GetUrls();

		WebServerConnectionElement FindConnection(string url);
	}
}