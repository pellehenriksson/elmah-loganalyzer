using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Infrastructure.Web
{
	public interface IWebRequestHelper
	{
		string Uri(NetworkConnection connection);
	}
}
