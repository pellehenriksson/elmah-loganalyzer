namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Abstract
{
	public interface ICacheHelper
	{
		T Get<T>(string key);

		void Set<T>(string key, T data);
	}
}
