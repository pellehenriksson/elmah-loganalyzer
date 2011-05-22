using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Infrastructure.Web
{
	public interface IUrlPing
	{
		bool Ping(NetworkConnection connection);
	}
}