using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Constants;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class ErrorLog
	{
		private static readonly List<string> IgnoreList = new List<string> { "ALL_HTTP", "ALL_RAW" };

		public ErrorLog()
		{
			ServerVariables = new List<NameValuePair>();
			Cookies = new List<NameValuePair>();
			FormValues = new List<NameValuePair>();
			QuerystringValues = new List<NameValuePair>();
			ClientInformation = new ClientInformation();
			StatusCodeInformation = new HttpStatusCodeInformation();
		}

		public string ErrorId { get; set; }

		public string Host { get; set; }
		
		public string Type { get; set; }
		
		public string Message { get; set; }
		
		public string Source { get; set; }
		
		public string Details { get; set; }
		
		public DateTime Time { get; set; }

		public string StatusCode { get; set; }
		
		public string User { get; private set; }

		public string Url { get; private set; }

		public string CleanUrl { get; private set; }

		public string HttpUserAgent { get; private set; }

		public string LocalIpAddress { get; private set; }

		public List<NameValuePair> ServerVariables { get; private set; }

		public List<NameValuePair> QuerystringValues { get; private set; }

		public List<NameValuePair> FormValues { get; private set; }

		public List<NameValuePair> Cookies { get; private set; }

		public ClientInformation ClientInformation { get; private set; }

		public HttpStatusCodeInformation StatusCodeInformation { get; private set; }

		public void SetClientInformation(ClientInformation information)
		{
			if (information == null)
			{
				throw new ArgumentNullException("information");	
			}

			ClientInformation = information;
		}

		public void SetStatusCodeInformation(HttpStatusCodeInformation information)
		{
			if (information == null)
			{
				throw new ArgumentNullException("information");
			}

			StatusCodeInformation = information;
		}

		public void AddServerVariable(string name, string value)
		{
			if (!ShouldBeIncluded(name))
			{
				return;
			}

			if (name == HttpServerVariables.LogonUser)
			{
				User = value.ToLowerInvariant();
			}
			
			if (name == HttpServerVariables.Url)
			{
				Url = value.ToLowerInvariant();
				CleanUrl = UrlCleaner.Clean(Url);
			}

			if (name == HttpServerVariables.HttpUserAgent)
			{
				HttpUserAgent = value;
			}

			if (name == HttpServerVariables.LocalAddress)
			{
				LocalIpAddress = value;
			}

			ServerVariables.Add(new NameValuePair(name, value));
		}

		public void AddQuerystringValue(string name, string value)
		{
			QuerystringValues.Add(new NameValuePair(name, value));
		}

		public void AddFormValue(string name, string value)
		{
			FormValues.Add(new NameValuePair(name, value));
		}

		public void AddCookie(string name, string value)
		{
			Cookies.Add(new NameValuePair(name, value));
		}

		private static bool ShouldBeIncluded(string name)
		{
			return !IgnoreList.Contains(name);
		}
	}
}
