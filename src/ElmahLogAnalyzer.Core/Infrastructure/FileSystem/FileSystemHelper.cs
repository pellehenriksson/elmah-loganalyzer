using System;
using System.IO;
using System.Text;

namespace ElmahLogAnalyzer.Core.Infrastructure.FileSystem
{
	public class FileSystemHelper : IFileSystemHelper
	{
		public bool FileExists(string path)
		{
			return File.Exists(path);
		}

		public bool DirectoryExists(string directory)
		{
			return Directory.Exists(directory);
		}

		public string[] GetFilesFromDirectory(string directory, string filePattern)
		{
			return Directory.GetFiles(directory, filePattern, SearchOption.TopDirectoryOnly);
		}

		public string GetFileContent(string path)
		{
			return File.ReadAllText(path, Encoding.UTF8);
		}

		public string GetCurrentDirectory()
		{
			return Directory.GetCurrentDirectory();
		}

		public void CreateDirectory(string downloadDirectory)
		{
			Directory.CreateDirectory(downloadDirectory);
		}

		public void CreateTextFile(string path, string content)
		{
			using (var writer = File.CreateText(path))
			{
				writer.Write(content);
			}
		}

		public void DeleteFile(string file)
		{
			File.Delete(file);
		}
	}
}
