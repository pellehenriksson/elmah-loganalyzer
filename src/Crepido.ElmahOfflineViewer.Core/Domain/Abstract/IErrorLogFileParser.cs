namespace Crepido.ElmahOfflineViewer.Core.Domain.Abstract
{
	public interface IErrorLogFileParser
	{
		ErrorLog Parse(string content);
	}
}
