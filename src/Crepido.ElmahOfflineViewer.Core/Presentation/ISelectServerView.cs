using System;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public interface ISelectServerView
	{
		event EventHandler OnConnectToServer;

		string Url { get; }

		void DisplayErrorMessage();
	}
}
