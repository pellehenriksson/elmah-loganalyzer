using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeClientInformationResolver : IClientInformationResolver
	{
		public ClientInformation Resolve(string httpUserAgent)
		{
			return new ClientInformation();
		}
	}
}
