namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IErrorLogFileParser
	{
		ErrorLog Parse(string content);
	}
}
