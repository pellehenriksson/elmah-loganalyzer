using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Configuration;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToDatabaseFilePresenter
	{
		private readonly IFileSystemHelper _fileSystemHelper;
		private readonly IDatabaseConnectionsHelper _databaseConnectionsHelper;

		public ConnectToDatabaseFilePresenter(IConnectToDatabaseFileView view, IFileSystemHelper fileSystemHelper, IDatabaseConnectionsHelper databaseConnectionsHelper)
		{
			View = view;
			_fileSystemHelper = fileSystemHelper;
			_databaseConnectionsHelper = databaseConnectionsHelper;

			RegisterEvents();

			View.LoadConnections(_databaseConnectionsHelper.GetNames(ErrorLogSources.SqlServerCompact.ToString()));
		}

		public IConnectToDatabaseFileView View { get; private set; }

		private void RegisterEvents()
		{
			View.OnConnectionSelected += (sender, args) =>
			{
			    var connection = _databaseConnectionsHelper.FindConnection(args.Url);
				View.Server = connection.File;
			};

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
