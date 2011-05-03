using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Abstract;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class DataSourceService : IDataSourceService
	{
		private const string FileFilterPattern = "error-*.xml";
		
		private readonly IErrorLogFileParser _parser;
		private readonly ILog _log;

		public DataSourceService(IErrorLogFileParser parser, ILog log)
		{
			_parser = parser;
			_log = log;
		}
		
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

		private static IEnumerable<string> GetErrorLogFilesFromDirectory(string directory)
		{
			return Directory.GetFiles(directory, FileFilterPattern, SearchOption.AllDirectories);
		}

		private static string GetContentFor(string file)
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
