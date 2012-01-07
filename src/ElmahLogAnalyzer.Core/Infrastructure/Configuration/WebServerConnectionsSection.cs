using System.Configuration;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public class WebServerConnectionsSection : ConfigurationSection
	{
		[ConfigurationProperty("connections")]
		public WebServerConnectionElementCollection Settings
		{
			get { return this["connections"] as WebServerConnectionElementCollection; }
		}
	}
}
