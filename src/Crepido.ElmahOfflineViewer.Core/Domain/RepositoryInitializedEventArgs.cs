using System;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class RepositoryInitializedEventArgs : EventArgs
	{
		public RepositoryInitializedEventArgs(string directory, int totalNumberOfLogs)
		{
			Directory = directory;
			TotalNumberOfLogs = totalNumberOfLogs;
		}

		public string Directory { get; private set; }

		public int TotalNumberOfLogs { get; private set; }
	}
}
