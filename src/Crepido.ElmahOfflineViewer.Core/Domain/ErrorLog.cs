using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLog
	{
		private const string ServerVariableUser = "LOGON_USER";
		private const string ServerVariableUrl = "URL";

		public ErrorLog()
		{
			ServerVariables = new List<ServerVariable>();
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

		public List<ServerVariable> ServerVariables { get; private set; }

		public void AddServerVariable(string name, string value)
		{
			if (name == ServerVariableUser)
			{
				User = value;
			}

			if (name == ServerVariableUrl)
			{
				Url = value;
				CleanUrl = UrlResolver.Resolve(Url);
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
