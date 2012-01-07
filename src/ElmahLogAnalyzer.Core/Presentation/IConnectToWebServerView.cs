using System;
using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToWebServerView
	{
		event EventHandler<ConnectToServerEventArgs> OnConnectToServer;

		event EventHandler<ConnectionSelectedEventArgs> OnConnectionSelected;

		string Url { get; set; }

		void LoadConnectionUrls(List<string> urls);

		void DisplayConnection(string username, string password, string domain);

		void DisplayErrorMessage(string message);

		void ClearErrorMessage();

		void CloseView();
	}
}
