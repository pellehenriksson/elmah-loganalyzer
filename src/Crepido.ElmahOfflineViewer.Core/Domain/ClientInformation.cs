namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ClientInformation
	{
		private const string DefaultValue = "UNKNOWN";

		public ClientInformation()
		{
			Platform = DefaultValue;
			OperatingSystem = DefaultValue;
			Browser = DefaultValue;
		}

		public string Browser { get; set; }
		
		public string Platform { get; set; }

		public string OperatingSystem { get; set; }
	}
}
