using ElmahLogAnalyzer.Core.Constants;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class ClientInformation
	{
		public ClientInformation()
		{
			Platform = Platforms.Unknown;
			OperatingSystem = "UNKNOWN";
			Browser = Browsers.Unknown;
			Description = string.Empty;
			HttpUserAgentString = string.Empty;
		}

		public string Browser { get; set; }
		
		public string Platform { get; set; }

		public string OperatingSystem { get; set; }

		public string Description { get; set; }

		public string HttpUserAgentString { get; set; }
	}
}
