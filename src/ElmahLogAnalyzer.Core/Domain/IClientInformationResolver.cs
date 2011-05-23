namespace ElmahLogAnalyzer.Core.Domain
{
	public interface IClientInformationResolver
	{
		ClientInformation Resolve(string httpUserAgent);
	}
}
