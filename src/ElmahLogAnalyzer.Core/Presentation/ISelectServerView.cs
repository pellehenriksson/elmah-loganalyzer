using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface ISelectServerView
	{
		event EventHandler<ConnectToServerEventArgs> OnConnectToServer;

		string Url { get; set; }

		void DisplayErrorMessage(string message);

		void ClearErrorMessage();

		void CloseView();
	}
}
