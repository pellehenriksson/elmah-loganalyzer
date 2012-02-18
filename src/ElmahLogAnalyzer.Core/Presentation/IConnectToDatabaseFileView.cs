using System;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToDatabaseFileView : IConnectToDatabaseConnectionInformation
	{
		event EventHandler OnConnectToDatabase;

		void DisplayErrorMessage(string message);

		void ClearErrorMessage();

		void CloseView();
	}

	public interface IConnectToSqlServerCompactView : IConnectToDatabaseFileView
	{
	}

	public interface IConnectToAccessView : IConnectToDatabaseFileView
	{
	}
}
