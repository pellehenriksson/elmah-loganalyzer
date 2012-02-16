namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IErrorLogDownloader
	{
		string DownloadDirectory { get; }

		void Download();
	}
}