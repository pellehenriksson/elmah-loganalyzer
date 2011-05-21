using System.IO;
using System.Net;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
	public class WebRequestHelper : IWebRequestHelper
	{
		public string Uri(NetworkConnection	connection)
		{
			string result;

			using (var client = new WebClient())
			{
				if (connection.HasCredentials)
				{
					client.UseDefaultCredentials = false;
					client.Credentials = connection.GetCredentials();
				}

				var response = client.OpenRead(connection.Uri.AbsoluteUri);
				
				// TODO Check content-type is the expected one!
				// TODO Use charset in response Content-Type header
				using (var reader = new StreamReader(response))
				{
					result = reader.ReadToEnd();
				}
			}

			return result;
		}
	}
}
