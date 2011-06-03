using System;
using System.Net;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Logging;

namespace ElmahLogAnalyzer.Core.Infrastructure.Web
{
	public class UrlPing : IUrlPing
	{
		private readonly ILog _log;

		public UrlPing(ILog log)
		{
			_log = log;
		}

		public Tuple<bool, string> Ping(NetworkConnection connection)
		{
			_log.Debug(string.Format("Make request to: {0}", connection.Uri));

			var request = (HttpWebRequest)WebRequest.Create(connection.Uri);

			if (connection.HasCredentials)
			{
				request.UseDefaultCredentials = false;
				request.Credentials = connection.GetCredentials();
			
				_log.Debug(string.Format("With credentials username: {0} domain: {1}", connection.GetCredentials().UserName, connection.GetCredentials().Domain));
			}

			try
			{
				using (var response = (HttpWebResponse)request.GetResponse())
				{
					var responseUrl = response.ResponseUri.AbsoluteUri;

					_log.Debug(string.Format("Response url was: {0}", responseUrl));
					_log.Debug(string.Format("Response code: {0}", response.StatusDescription));

					var result = connection.Uri.AbsoluteUri == responseUrl;
					
					return new Tuple<bool, string>(result, response.StatusDescription);
				}
			}
			catch (WebException ex)
			{
				_log.Error(ex);
				return new Tuple<bool, string>(false, ex.Message);
			}
		}
	}
}
