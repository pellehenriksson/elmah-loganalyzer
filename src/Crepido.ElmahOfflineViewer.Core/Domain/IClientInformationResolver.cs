namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface IClientInformationResolver
	{
		ClientInformation Resolve(string httpUserAgent);
	}
}
