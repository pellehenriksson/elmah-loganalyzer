using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeClientInformationResolver : IClientInformationResolver
	{
		public ClientInformation Resolve(string httpUserAgent)
		{
			return new ClientInformation();
		}
	}
}
