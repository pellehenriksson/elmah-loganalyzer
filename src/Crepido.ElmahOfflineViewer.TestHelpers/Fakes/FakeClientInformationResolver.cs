using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;

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
