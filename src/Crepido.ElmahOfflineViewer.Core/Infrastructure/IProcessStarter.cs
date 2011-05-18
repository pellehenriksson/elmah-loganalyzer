namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	using System;

	public interface IProcessStarter
	{
		void Run(Uri url);

		void Run(Uri url, string arguments);
	}
}
