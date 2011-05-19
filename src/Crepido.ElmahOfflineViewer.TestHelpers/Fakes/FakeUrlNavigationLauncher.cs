using System;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeUrlNavigationLauncher : IUrlNavigationLauncher
	{
		public Uri RunWithUrl { get; private set; }

		public void Launch(Uri url)
		{
			RunWithUrl = url;
		}
	}
}
