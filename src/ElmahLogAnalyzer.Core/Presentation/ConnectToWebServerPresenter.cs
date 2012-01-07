using System;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Configuration;
using ElmahLogAnalyzer.Core.Infrastructure.Web;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToWebServerPresenter
	{
		private readonly IUrlPing _urlPing;
		private readonly IWebServerConnectionsHelper _webServerConnectionsHelper;

		public ConnectToWebServerPresenter(IConnectToWebServerView view, IUrlPing urlPing, IWebServerConnectionsHelper webServerConnectionsHelper)
		{
			View = view;
			_urlPing = urlPing;
			_webServerConnectionsHelper = webServerConnectionsHelper;

			RegisterEvents();

			View.LoadConnectionUrls(_webServerConnectionsHelper.GetUrls());
		}

		public IConnectToWebServerView View { get; private set; }

		public NetworkConnection Connnection { get; private set; }

		private void RegisterEvents()
		{
			View.OnConnectToServer += View_OnConnectToServer;
			View.OnConnectionSelected += ViewOnConnectionOnConnectionSelected;
		}

		private void ViewOnConnectionOnConnectionSelected(object sender, ConnectionSelectedEventArgs args)
		{
			var configuration = _webServerConnectionsHelper.FindConnection(args.Url);
			if (configuration != null)
			{
				View.DisplayConnection(configuration.Username, configuration.Password, configuration.Domain);
			}
			else
			{
				View.DisplayConnection(string.Empty, string.Empty, string.Empty);
			}
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

				if (!serverResponded.Item1)
				{
					View.DisplayErrorMessage(serverResponded.Item2);
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
