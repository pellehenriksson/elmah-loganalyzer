using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class SelectServerPresenter
	{
		private IUrlPing _urlPing;

		public SelectServerPresenter(ISelectServerView view, IUrlPing urlPing)
		{
			View = view;
			_urlPing = urlPing;
		}

		public ISelectServerView View { get; private set; }
	}
}
