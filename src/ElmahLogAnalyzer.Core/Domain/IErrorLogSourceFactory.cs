namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IErrorLogSourceFactory
	{
		IErrorLogSource Build(string path);
	}
}