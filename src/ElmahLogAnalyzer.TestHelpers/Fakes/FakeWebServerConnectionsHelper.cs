using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Infrastructure.Configuration;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeWebServerConnectionsHelper : IWebServerConnectionsHelper
	{
		public WebServerConnectionElementCollection GetConnections()
		{
			throw new NotImplementedException();
		}

		public List<string> GetUrls()
		{
			return new List<string> { "http://localhost:1234/myapp", "http://production/myapp" };
		}

		public WebServerConnectionElement FindConnection(string url)
		{
			if (String.IsNullOrWhiteSpace(url))
			{
				return new WebServerConnectionElement();
			}

			return new WebServerConnectionElement
			       	{
			       		Url = "http://production/myapp", 
						Username = "pelle", 
						Password = "secret", 
						Domain = "mydomain"
			       	};
		}
	}
}
