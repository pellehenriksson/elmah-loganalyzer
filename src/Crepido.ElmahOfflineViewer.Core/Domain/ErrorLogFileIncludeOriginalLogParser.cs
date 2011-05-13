namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLogFileIncludeOriginalLogParser : IErrorLogFileParser
	{
		private readonly IErrorLogFileParser _fileParse;

		public ErrorLogFileIncludeOriginalLogParser(IErrorLogFileParser fileParse)
		{
			_fileParse = fileParse;
		}

		public ErrorLog Parse(string content)
		{
			var result = _fileParse.Parse(content);
			result.OriginalLog = content;
			return result;
		}
	}
}
