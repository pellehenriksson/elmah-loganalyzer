using System;

namespace ElmahLogAnalyzer.Core.Infrastructure.Web
{
	public interface IUrlNavigationLauncher
	{
		void Launch(Uri url);
	}
}
