namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Cache
{
	public interface ICacheHelper
	{
		T Get<T>(string key);

		void Set<T>(string key, T data);
	}
}
