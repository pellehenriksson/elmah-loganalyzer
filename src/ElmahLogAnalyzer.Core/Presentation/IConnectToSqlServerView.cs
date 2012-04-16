using System;
using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToSqlServerView : IConnectToDatabaseConnectionInformation
	{
		event EventHandler OnConnectToDatabase;

		event EventHandler<ConnectionSelectedEventArgs> OnConnectionSelected;

		void LoadConnections(List<string> connections);

		void DisplayErrorMessage(string message);

		void ClearErrorMessage();

		void CloseView();
	}
}
