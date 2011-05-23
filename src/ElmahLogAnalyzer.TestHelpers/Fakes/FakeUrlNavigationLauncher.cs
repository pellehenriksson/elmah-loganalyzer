using System;
using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
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
