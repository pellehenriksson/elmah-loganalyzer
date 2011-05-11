using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeErrorLogSourceFactory : IErrorLogSourceFactory
	{
		public IErrorLogSource Build(string path)
		{
			return new FakeDataSource();
		}
	}
}
