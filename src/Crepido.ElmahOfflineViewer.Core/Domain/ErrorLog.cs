using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLog
	{
		public ErrorLog()
		{
			ServerVariables = new List<ServerVariable>();
			ClientInformation = new ClientInformation();
		}

		public ErrorLog(Guid id, string type, string source, DateTime time, string user, string url) : this()
		{
			ErrorId = id.ToString();
			Type = type;
			Source = source;
			Time = time;
			User = user;
			Url = url;
			CleanUrl = UrlResolver.Resolve(Url);
		}
		
		public string ErrorId { get; set; }

		public string Host { get; set; }
		
		public string Type { get; set; }
		
		public string Message { get; set; }
		
		public string Source { get; set; }
		
		public string Details { get; set; }
		
		public DateTime Time { get; set; }

		public string User { get; private set; }

		public string Url { get; private set; }

		public string CleanUrl { get; private set; }

		public string HttpUserAgent { get; private set; }

		public List<ServerVariable> ServerVariables { get; private set; }

		public ClientInformation ClientInformation { get; private set; }

		public void SetClientInformation(ClientInformation information)
		{
			if (information == null)
			{
				throw new ArgumentNullException("information");	
			}

			ClientInformation = information;
		}

		public void AddServerVariable(string name, string value)
		{
			if (name == HttpServerVariables.LogonUser)
			{
				User = value.ToLowerInvariant();
			}

			if (name == HttpServerVariables.Url)
			{
				Url = value.ToLowerInvariant();
				CleanUrl = UrlResolver.Resolve(Url);
			}

			if (name == HttpServerVariables.HttpUserAgent)
			{
				HttpUserAgent = value;
			}

			ServerVariables.Add(new ServerVariable(name, value));
		}

		public class ServerVariable
		{
			public ServerVariable(string name, string value)
			{
				Name = name;
				Value = value;
			}

			public string Name { get; private set; }

			public string Value { get; private set; }
		}
	}
}
