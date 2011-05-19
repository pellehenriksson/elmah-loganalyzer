using System;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Web
{
	public interface IUrlNavigationLauncher
	{
		void Launch(Uri url);
	}
}
