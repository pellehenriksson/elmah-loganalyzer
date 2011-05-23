using System.Net;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Infrastructure.Web
{
	public class UrlPing : IUrlPing
	{
		public bool Ping(NetworkConnection connection)
		{
			var request = (HttpWebRequest)WebRequest.Create(connection.Uri);

			if (connection.HasCredentials)
			{
				request.UseDefaultCredentials = false;
				request.Credentials = connection.GetCredentials();
			}

			try
			{
				using (var response = (HttpWebResponse)request.GetResponse())
				{
					var responseUrl = response.ResponseUri.AbsoluteUri;
					return connection.Uri.AbsoluteUri == responseUrl;
				}
			}
			catch (WebException)
			{
				return false;
			}
		}
	}
}
