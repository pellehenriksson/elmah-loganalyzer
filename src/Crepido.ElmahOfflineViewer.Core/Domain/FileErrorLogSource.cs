using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class FileErrorLogSource : IErrorLogSource
	{
		private const string FileFilterPattern = "error-*.xml";
		
		private readonly IErrorLogFileParser _parser;
		private readonly ISettingsManager _settingsManager;
		private readonly ILog _log;

		public FileErrorLogSource(IErrorLogFileParser parser, ISettingsManager settingsManager, ILog log)
		{
			_parser = parser;
			_settingsManager = settingsManager;
			_log = log;
		}

		public string Path { get; private set; }

		public List<ErrorLog> GetLogs(string directory)
		{
			if (!Directory.Exists(directory))
			{
				_log.Error(string.Format("Directory: {0} does not exist", directory));
				throw new ApplicationException(string.Format("The directory: {0} was not found", directory));
			}

			var files = GetErrorLogFilesFromDirectory(directory);
			return ParseFiles(files);
		}

		private IEnumerable<string> GetErrorLogFilesFromDirectory(string directory)
		{
			var files = Directory.GetFiles(directory, FileFilterPattern, SearchOption.AllDirectories);

			if (_settingsManager.GetMaxNumberOfLogs() == -1)
			{
				return files;
			}

			return files.OrderByDescending(x => x).Take(_settingsManager.GetMaxNumberOfLogs());
		}

		private string GetContentFor(string file)
		{
			return File.ReadAllText(file, Encoding.UTF8);
		}

		private List<ErrorLog> ParseFiles(IEnumerable<string> files)
		{
			var result = new List<ErrorLog>();
			foreach (var file in files)
			{
				_log.Debug(string.Format("Parsing file: {0}", file));

				var content = GetContentFor(file);
				var errorLog = _parser.Parse(content);

				if (errorLog == null)
				{
					_log.Error(string.Format("Failed to parse file: {0}", file));
					continue;
				}

				result.Add(errorLog);
			}

			return result;
		}
	}
}
