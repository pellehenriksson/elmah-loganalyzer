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
			BrowserVersion = DefaultValue;
		}

		public string Browser { get; set; }

		public string BrowserVersion { get; set; }

		public string Platform { get; set; }

		public string OperatingSystem { get; set; }

		public string BrowserDisplayName
		{
			get { return string.Format("{0} {1}", Browser, BrowserVersion); }
		}
	}
}
