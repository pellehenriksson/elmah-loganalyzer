using System;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToDatabaseView : IConnectToDatabaseConnectionInfo
	{
		ErrorLogSources Source { get; }
	}

	public interface IConnectToDatabaseConnectionInformationView : IConnectToDatabaseConnectionInfo
	{
		event EventHandler<OnValidatingEventArgs> OnInputValidated;

		void ForceInputValidation();
	}

	public interface IConnectToDatabaseConnectionInfo
	{
		string File { get; }

		string Server { get; }

		string Port { get; }

		string Database { get; }

		string Username { get; }

		string Password { get; }

		bool UseIntegratedSecurity { get; }
	}

	public class OnValidatingEventArgs : EventArgs
	{
		public OnValidatingEventArgs(bool isValid)
		{
			IsValid = isValid;
		}

		public bool IsValid { get; private set; }
	}
}
