using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToDatabaseFilePresenter
	{
		private readonly IFileSystemHelper _fileSystemHelper;

		public ConnectToDatabaseFilePresenter(IConnectToDatabaseFileView view, IFileSystemHelper fileSystemHelper)
		{
			View = view;
			_fileSystemHelper = fileSystemHelper;

			RegisterEvents();
		}

		public IConnectToDatabaseFileView View { get; private set; }

		private void RegisterEvents()
		{
			View.OnConnectToDatabase += (sender, args) =>
			{
				if (string.IsNullOrWhiteSpace(View.Server))
				{
					View.DisplayErrorMessage("No file selected");
					return;
				}

				if (!_fileSystemHelper.FileExists(View.Server))
				{
					View.DisplayErrorMessage("File does not exist");
					return;
				}

				View.CloseView();
			};
		}
	}
}
