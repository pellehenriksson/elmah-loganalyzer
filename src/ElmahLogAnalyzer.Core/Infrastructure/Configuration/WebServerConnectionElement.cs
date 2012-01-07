using System.Configuration;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public class WebServerConnectionElement : ConfigurationElement
	{
		[ConfigurationProperty("url", IsRequired = true, IsKey = true)]
		public string Url
		{
			get { return (string)this["url"]; }
			set { this["url"] = value; }
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

		[ConfigurationProperty("domain", IsRequired = false)]
		public string Domain
		{
			get { return (string)this["domain"]; }
			set { this["domain"] = value; }
		}
	}
}
