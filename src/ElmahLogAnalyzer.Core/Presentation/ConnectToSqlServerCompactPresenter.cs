using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToSqlServerCompactPresenter : ConnectToDatabaseFilePresenter
	{
		public ConnectToSqlServerCompactPresenter(IConnectToSqlServerCompactView view, IFileSystemHelper fileSystemHelper) : base(view, fileSystemHelper)
		{
		}
	}
}