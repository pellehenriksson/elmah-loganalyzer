namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface IErrorLogFileParser
	{
		ErrorLog Parse(string content);
	}
}
