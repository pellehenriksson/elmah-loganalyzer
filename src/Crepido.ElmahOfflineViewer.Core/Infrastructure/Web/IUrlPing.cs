namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
    using System;

    public interface IUrlPing
	{
		bool Ping(Uri url);
	}
}