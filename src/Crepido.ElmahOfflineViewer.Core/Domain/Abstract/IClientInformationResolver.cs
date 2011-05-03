namespace Crepido.ElmahOfflineViewer.Core.Domain.Abstract
{
	public interface IClientInformationResolver
	{
		ClientInformation Resolve(string httpUserAgent);
	}
}
