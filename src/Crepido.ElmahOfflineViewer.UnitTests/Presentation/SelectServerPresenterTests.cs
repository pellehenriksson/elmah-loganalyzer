using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using Moq;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Presentation
{
	[TestFixture]
	public class SelectServerPresenterTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsView()
		{
			// act
			var view = new Mock<ISelectServerView>();
			var presenter = new SelectServerPresenter(view.Object, new FakeUrlPing());

			// assert
			Assert.That(presenter.View, Is.EqualTo(view.Object));
		}

		[Test]
		public void View_OnConnectToServer_UrlIsMissing_DisplayErrorMessage()
		{
			// arrange
			var view = new Mock<ISelectServerView>();
			var presenter = new SelectServerPresenter(view.Object, new FakeUrlPing());

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
			var view = new Mock<ISelectServerView>();
			var ping = new Mock<IUrlPing>();

			ping.Setup(x => x.Ping(It.IsAny<NetworkConnection>())).Returns(false);

			var presenter = new SelectServerPresenter(view.Object, ping.Object);

			// act
			view.Raise(x => x.OnConnectToServer += null, new ConnectToServerEventArgs("http://www.test.nu/elmah.axd", string.Empty, string.Empty, string.Empty));

			// assert
			view.Verify(x => x.ClearErrorMessage(), Times.Once());
			view.Verify(x => x.DisplayErrorMessage("Failed to connect to server"), Times.Once());
		}

		[Test]
		public void View_OnConnectToServer_PingingUrlSucceeded_CloseView()
		{
			// arrange
			var view = new Mock<ISelectServerView>();
			var ping = new Mock<IUrlPing>();

			ping.Setup(x => x.Ping(It.IsAny<NetworkConnection>())).Returns(true);

			var presenter = new SelectServerPresenter(view.Object, ping.Object);

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
			var view = new Mock<ISelectServerView>();
			var ping = new Mock<IUrlPing>();

			ping.Setup(x => x.Ping(It.IsAny<NetworkConnection>())).Throws(new ApplicationException("some error"));

			var presenter = new SelectServerPresenter(view.Object, ping.Object);

			// act
			view.Raise(x => x.OnConnectToServer += null, new ConnectToServerEventArgs("http://www.test.nu/elmah.axd", string.Empty, string.Empty, string.Empty));

			// assert
			view.Verify(x => x.ClearErrorMessage(), Times.Once());
			view.Verify(x => x.DisplayErrorMessage("some error"), Times.Once());
		}
	}
}
