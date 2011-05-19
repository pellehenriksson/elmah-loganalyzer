using System;
using System.IO;
using System.Net;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
	public class WebRequestHelper : IWebRequestHelper
	{
		public string Uri(Uri url)
		{
			string result;

			using (var client = new WebClient())
			{
				var response = client.OpenRead(url);
				//// TODO Check content-type is the expected one!
				//// TODO Use charset in response Content-Type header
				using (var reader = new StreamReader(response))
				{
					result = reader.ReadToEnd();
				}
			}

			return result;
		}
	}
}
