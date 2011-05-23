using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeErrorLogSourceFactory : IErrorLogSourceFactory
	{
		public IErrorLogSource Build(string path)
		{
			return new FakeDataSource();
		}
	}
}
