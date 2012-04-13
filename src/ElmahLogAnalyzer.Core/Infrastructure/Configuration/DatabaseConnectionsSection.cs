using System.Configuration;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public class DatabaseConnectionsSection : ConfigurationSection
	{
		[ConfigurationProperty("connections")]
		public DatabaseConnectionElementCollection Settings
		{
			get { return this["connections"] as DatabaseConnectionElementCollection; }
		}
	}
}
