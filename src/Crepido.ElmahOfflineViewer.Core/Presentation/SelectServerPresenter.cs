using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class SelectServerPresenter
	{
		private readonly IUrlPing _urlPing;

		public SelectServerPresenter(ISelectServerView view, IUrlPing urlPing)
		{
			View = view;
			_urlPing = urlPing;

			RegisterEvents();
		}

		public ISelectServerView View { get; private set; }

		public NetworkConnection Connnection { get; private set; }

		private void RegisterEvents()
		{
			View.OnConnectToServer += View_OnConnectToServer;
		}

		private void View_OnConnectToServer(object sender, ConnectToServerEventArgs e)
		{
			View.ClearErrorMessage();
			
			if (!e.Url.HasValue())
			{
				View.DisplayErrorMessage("Invalid url");
				return;
			}

			try
			{
				var elmahUrl = new ElmahUrlHelper().ResolveElmahRootUrl(e.Url);
				var connection = new NetworkConnection(elmahUrl);

				if (e.HasCredentials)
				{
					connection.SetCredentials(e.UserName, e.Password, e.Domain);
				}
				
				var serverResponded = _urlPing.Ping(connection);

				if (!serverResponded)
				{
					// should include more information about the failure
					View.DisplayErrorMessage("Failed to connect to server");
					return;
				}

				Connnection = connection;

				View.CloseView();
			}
			catch (ArgumentException)
			{
				View.DisplayErrorMessage("Invalid url");
			}
			catch (Exception ex)
			{
				View.DisplayErrorMessage(ex.Message);
			}
		}
	}
}
