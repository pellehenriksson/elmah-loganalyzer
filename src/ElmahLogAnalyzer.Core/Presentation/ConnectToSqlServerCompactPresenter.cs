using ElmahLogAnalyzer.Core.Infrastructure.Configuration;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToSqlServerCompactPresenter : ConnectToDatabaseFilePresenter
	{
		public ConnectToSqlServerCompactPresenter(IConnectToSqlServerCompactView view, IFileSystemHelper fileSystemHelper, IDatabaseConnectionsHelper databaseConnectionsHelper)
			: base(view, fileSystemHelper, databaseConnectionsHelper)
		{
		}
	}
}