using System;
using System.Net;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class NetworkConnection
	{
		public NetworkConnection(string url)
		{
			Uri = new Uri(url, UriKind.Absolute);
		}
		
		public Uri Uri { get; private set; }

		public bool HasCredentials
		{
			get { return Credentials != null; }
		}

		public bool IsHttps
		{
			get { return Uri.Scheme.Equals("https", StringComparison.InvariantCultureIgnoreCase); }
		}

		private NetworkCredential Credentials { get; set; }
		
		public void SetCredentials(string username, string password, string domain)
		{
			Credentials = new NetworkCredential(username, password, domain);
		}

		public NetworkCredential GetCredentials()
		{
			return Credentials;
		}

		public NetworkConnection CopyWithCredentials(string url)
		{
			var connection = new NetworkConnection(url) { Credentials = GetCredentials() };
			return connection;
		}
	}
}
