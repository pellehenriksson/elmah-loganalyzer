using System;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class RepositoryInitializedEventArgs : EventArgs
	{
		public RepositoryInitializedEventArgs(string directory)
		{
			Directory = directory;
		}

		public string Directory { get; private set; }	
	}
}
