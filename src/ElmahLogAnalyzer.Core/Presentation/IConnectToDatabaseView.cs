using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToDatabase : IConnectToDatabaseConnectionInformationView
	{
		ErrorLogSourcesEnum Source { get; }
	}

	public interface IConnectToDatabaseConnectionInformationView
	{
		string File { get; }

		string Server { get; }

		string Port { get; }

		string Database { get; }

		string Username { get; }

		string Password { get; }

		bool UseIntegratedSecurity { get; }
	}
}
