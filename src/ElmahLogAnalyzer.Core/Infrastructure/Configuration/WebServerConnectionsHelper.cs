using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public class WebServerConnectionsHelper : IWebServerConnectionsHelper
	{
		private static readonly WebServerConnectionsSection Section;
		
		static WebServerConnectionsHelper()
		{
			Section = (WebServerConnectionsSection)ConfigurationManager.GetSection("webserverConnections");
		}

		public WebServerConnectionElementCollection GetConnections()
		{
			return Section.Settings;
		}

		public List<string> GetUrls()
		{
			return Section.Settings.Cast<WebServerConnectionElement>().Select(x => x.Url).ToList();
		}

		public WebServerConnectionElement FindConnection(string url)
		{
			return Section.Settings
							.Cast<WebServerConnectionElement>()
							.FirstOrDefault(x => x.Url.Equals(url, StringComparison.InvariantCultureIgnoreCase));
		}
	}
}
