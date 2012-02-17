using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToSqlServerView : IConnectToDatabaseConnectionInformation
	{
		event EventHandler OnConnectToDatabase;

		void DisplayErrorMessage(string message);

		void ClearErrorMessage();

		void CloseView();
	}
}
