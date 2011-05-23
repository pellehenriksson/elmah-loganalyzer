using System;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToServerEventArgs : EventArgs
	{
		public ConnectToServerEventArgs(string url, string userName, string password, string domain)
		{
			Url = url;
			UserName = userName;
			Password = password;
			Domain = domain;
		}

		public string Url { get; private set; }

		public string UserName { get; private set; }
		
		public string Password { get; private set; }
		
		public string Domain { get; private set; }

		public bool HasCredentials
		{
			get { return UserName.HasValue() || Password.HasValue() || Domain.HasValue(); }
		}
	}
}
