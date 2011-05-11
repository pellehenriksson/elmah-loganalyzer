using Crepido.ElmahOfflineViewer.Core.Constants;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ClientInformation
	{
		public ClientInformation()
		{
			Platform = Platforms.Unknown;
			OperatingSystem = "UNKNOWN";
			Browser = Browsers.Unknown;
		}

		public string Browser { get; set; }
		
		public string Platform { get; set; }

		public string OperatingSystem { get; set; }
	}
}
