using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToDatabaseView : IConnectToDatabase
	{
		void LoadDatabaseOptions(List<NameValuePair> options);
	}

	public interface IConnectToDatabase : IConnectToDatabaseConnectionInformationView
	{
		string DatabaseType { get; set; }
	}

	public interface IConnectToDatabaseConnectionInformationView
	{
		string Server { get; set; }

		string Port { get; set; }

		string Database { get; set; }

		string Username { get; set; }

		string Password { get; set; }

		bool UseIntegratedSecurity { get; set; }
	}
}
