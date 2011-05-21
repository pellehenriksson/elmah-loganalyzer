using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
	public interface IUrlPing
	{
		bool Ping(NetworkConnection connection);
	}
}