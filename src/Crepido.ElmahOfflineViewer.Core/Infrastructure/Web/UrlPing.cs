using System.Net;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
	using System;

	public class UrlPing : IUrlPing
	{
		public bool Ping(Uri url)
		{
			var request = (HttpWebRequest)WebRequest.Create(url);

			try
			{
				//// todo: should verify that elmah.axd responded and not just some server
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
