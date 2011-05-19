namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.FileSystem
{
	public interface IFileSystemHelper
	{
		bool FileExists(string path);

		bool DirectoryExists(string directory);

		string[] GetFilesFromDirectory(string directory, string filePattern);

		string GetFileContent(string path);

		string GetCurrentDirectory();

		void CreateDirectory(string downloadDirectory);

		void CreateTextFile(string path, string content);
	}
}