using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
	public interface IWebRequestHelper
	{
		string Uri(NetworkConnection connection);
	}
}
