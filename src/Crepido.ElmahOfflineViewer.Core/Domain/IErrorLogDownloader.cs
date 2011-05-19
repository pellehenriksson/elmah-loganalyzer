using System;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface IErrorLogDownloader
	{
		string DownloadDirectory { get; }

		void Download(Uri url);
	}
}