using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToAccessPresenter : ConnectToDatabaseFilePresenter
	{
		public ConnectToAccessPresenter(IConnectToAccessView view, IFileSystemHelper fileSystemHelper) : base(view, fileSystemHelper)
		{
		}
	}
}