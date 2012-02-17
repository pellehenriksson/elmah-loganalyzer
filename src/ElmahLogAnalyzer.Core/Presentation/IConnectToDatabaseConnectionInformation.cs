using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToDatabaseConnectionInformation
	{
		ErrorLogSources Source { get; }

		string File { get; }

		string Server { get; }

		string Port { get; }

		string Database { get; }

		string Username { get; }

		string Password { get; }

		bool UseIntegratedSecurity { get; }
	}
}