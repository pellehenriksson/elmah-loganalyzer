using System.Configuration;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public class DatabaseConnectionElement : ConfigurationElement
	{
		[ConfigurationProperty("type", IsRequired = true)]
		public string Type
		{
			get { return (string)this["type"]; }
			set { this["type"] = value; }
		}

		[ConfigurationProperty("name", IsRequired = true, IsKey = true)]
		public string Name
		{
			get { return (string)this["name"]; }
			set { this["name"] = value; }
		}

		[ConfigurationProperty("server", IsRequired = false)]
		public string Server
		{
			get { return (string)this["server"]; }
			set { this["server"] = value; }
		}
		
		[ConfigurationProperty("database", IsRequired = false)]
		public string Database
		{
			get { return (string)this["database"]; }
			set { this["database"] = value; }
		}

		[ConfigurationProperty("username", IsRequired = false)]
		public string Username
		{
			get { return (string)this["username"]; }
			set { this["username"] = value; }
		}

		[ConfigurationProperty("password", IsRequired = false)]
		public string Password
		{
			get { return (string)this["password"]; }
			set { this["password"] = value; }
		}

		[ConfigurationProperty("file", IsRequired = false)]
		public string File
		{
			get { return (string)this["file"]; }
			set { this["file"] = value; }
		}
	}
}
