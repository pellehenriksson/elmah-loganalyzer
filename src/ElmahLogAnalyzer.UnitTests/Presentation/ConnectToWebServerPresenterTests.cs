using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Web;
using ElmahLogAnalyzer.Core.Presentation;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ConnectToWebServerPresenterTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsView()
		{
			// act
			var view = new Mock<IConnectToWebServerView>();
			var presenter = new ConnectToWebServerPresenter(view.Object, new FakeUrlPing(), new FakeWebServerConnectionsHelper());

			// assert
			Assert.That(presenter.View, Is.EqualTo(view.Object));
		}
		
		[Test]
		public void Ctor_LoadsConfiguredServerUrlsInView()
		{
			// act
			var view = new Mock<IConnectToWebServerView>();
			var presenter = new ConnectToWebServerPresenter(view.Object, new FakeUrlPing(), new FakeWebServerConnectionsHelper());

			// assert
			view.Verify(x => x.LoadConnectionUrls(It.IsAny<List<string>>()), Times.Once());
		}

		[Test]
		public void View_OnConnectionSelected_UrlIsPresent_DisplaysConfiguration()
		{
			// arrange
			var view = new Mock<IConnectToWebServerView>();
			var presenter = new ConnectToWebServerPresenter(view.Object, new FakeUrlPing(), new FakeWebServerConnectionsHelper());

			// act
			view.Raise(x => x.OnConnectionSelected += null, new ConnectionSelectedEventArgs("http://test.com"));

			// assert
			view.Verify(x => x.DisplayConnection("pelle", "secret", "mydomain"), Times.Once());
		}

		[Test]
		public void View_OnConnectionSelected_UrlIsEmpty_DisplaysEmptyConfiguration()
		{
			// arrange
			var view = new Mock<IConnectToWebServerView>();
			var presenter = new ConnectToWebServerPresenter(view.Object, new FakeUrlPing(), new FakeWebServerConnectionsHelper());

			// act
			view.Raise(x => x.OnConnectionSelected += null, new ConnectionSelectedEventArgs(string.Empty));

			// assert
			view.Verify(x => x.DisplayConnection(string.Empty, string.Empty, string.Empty), Times.Once());
		}

		[Test]
		public void View_OnConnectToServer_UrlIsMissing_DisplayErrorMessage()
		{
			// arrange
			var view = new Mock<IConnectToWebServerView>();
			var presenter = new ConnectToWebServerPresenter(view.Object, new FakeUrlPing(), new FakeWebServerConnectionsHelper());

			// act
			view.Raise(x => x.OnConnectToServer += null, new ConnectToServerEventArgs(string.Empty, string.Empty, string.Empty, string.Empty));

			// assert
			view.Verify(x => x.ClearErrorMessage(), Times.Once());
			view.Verify(x => x.DisplayErrorMessage("Invalid url"), Times.Once());
		}

		[Test]
		public void View_OnConnectToServer_PingingUrlFailed_DisplayErrorMessage()
		{
			// arrange
			var view = new Mock<IConnectToWebServerView>();
			var ping = new Mock<IUrlPing>();

			ping.Setup(x => x.Ping(It.IsAny<NetworkConnection>())).Returns(new Tuple<bool, string>(false, "some error"));

			var presenter = new ConnectToWebServerPresenter(view.Object, ping.Object, new FakeWebServerConnectionsHelper());

			// act
			view.Raise(x => x.OnConnectToServer += null, new ConnectToServerEventArgs("http://www.test.nu/elmah.axd", string.Empty, string.Empty, string.Empty));

			// assert
			view.Verify(x => x.ClearErrorMessage(), Times.Once());
			view.Verify(x => x.DisplayErrorMessage("some error"), Times.Once());
		}

		[Test]
		public void View_OnConnectToServer_PingingUrlSucceeded_CloseView()
		{
			// arrange
			var view = new Mock<IConnectToWebServerView>();
			var ping = new Mock<IUrlPing>();

			ping.Setup(x => x.Ping(It.IsAny<NetworkConnection>())).Returns(new Tuple<bool, string>(true, string.Empty));

			var presenter = new ConnectToWebServerPresenter(view.Object, ping.Object, new FakeWebServerConnectionsHelper());

			// act
			view.Raise(x => x.OnConnectToServer += null, new ConnectToServerEventArgs("http://www.test.nu/elmah.axd", string.Empty, string.Empty, string.Empty));

			// assert
			view.Verify(x => x.ClearErrorMessage(), Times.Once());
			view.Verify(x => x.CloseView(), Times.Once());
		}

		[Test]
		public void View_OnConnectToServer_PingThrowsException_DisplayErrorMessage()
		{
			// arrange
			var view = new Mock<IConnectToWebServerView>();
			var ping = new Mock<IUrlPing>();

			ping.Setup(x => x.Ping(It.IsAny<NetworkConnection>())).Throws(new ApplicationException("some error"));

			var presenter = new ConnectToWebServerPresenter(view.Object, ping.Object, new FakeWebServerConnectionsHelper());

			// act
			view.Raise(x => x.OnConnectToServer += null, new ConnectToServerEventArgs("http://www.test.nu/elmah.axd", string.Empty, string.Empty, string.Empty));

			// assert
			view.Verify(x => x.ClearErrorMessage(), Times.Once());
			view.Verify(x => x.DisplayErrorMessage("some error"), Times.Once());
		}
	}
}
