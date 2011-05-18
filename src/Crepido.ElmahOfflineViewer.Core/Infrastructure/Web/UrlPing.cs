using System.Net;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
	public class UrlPing : IUrlPing
	{
		public bool Ping(string url)
		{
			var request = (HttpWebRequest)WebRequest.Create(url);

			try
			{
				using (var response = (HttpWebResponse)request.GetResponse())
				{
					return response.StatusCode == HttpStatusCode.OK;
				}
			}
			catch (WebException)
			{
				return false;
			}
		}
	}
}
