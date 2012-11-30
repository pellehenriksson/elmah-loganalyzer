using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToDatabaseConnectionInformation
	{
		ErrorLogSources Source { get; }
		
		string Server { get; set; }

		string Schema { get; set; }

        string Application { get; set; }

		string Port { get; set; }

		string Database { get; set; }

		string Username { get; set; }

		string Password { get; set; }

		bool UseIntegratedSecurity { get; set; }
	}
}