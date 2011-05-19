namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface IErrorLogSourceFactory
	{
		IErrorLogSource Build(string path);
	}
}