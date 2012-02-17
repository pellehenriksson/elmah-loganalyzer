using System;
using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ConnectToSqlServerPresenterTest : UnitTestBase
	{
		private Mock<IConnectToSqlServerView> _view;

		[SetUp]
		public void Setup()
		{
			_view = new Mock<IConnectToSqlServerView>();
		}

		[Test]
		public void Ctor_SetsView()
		{
			// act
			var presenter = new ConnectToSqlServerPresenter(_view.Object);

			// assert
			Assert.That(presenter.View, Is.EqualTo(_view.Object));
		}

		[Test]
		public void OnConnectToDatabase_ServerIsMissing_DisplayErrorMessage()
		{
			// arrange
			var presenter = new ConnectToSqlServerPresenter(_view.Object);

			_view.Setup(x => x.Server).Returns(string.Empty);
			_view.Setup(x => x.Database).Returns("db");
			_view.Setup(x => x.UseIntegratedSecurity).Returns(true);

			// act
			_view.Raise(x => x.OnConnectToDatabase += null, new EventArgs());

			// assert
			_view.Verify(x => x.DisplayErrorMessage("Not all required fields have values"), Times.Once());
		}
		
		[Test]
		public void OnConnectToDatabase_DatabaseIsMissing_DisplayErrorMessage()
		{
			// arrange
			var presenter = new ConnectToSqlServerPresenter(_view.Object);

			_view.Setup(x => x.Server).Returns("server");
			_view.Setup(x => x.Database).Returns(string.Empty);
			_view.Setup(x => x.UseIntegratedSecurity).Returns(true);

			// act
			_view.Raise(x => x.OnConnectToDatabase += null, new EventArgs());

			// assert
			_view.Verify(x => x.DisplayErrorMessage("Not all required fields have values"), Times.Once());
		}

		[Test]
		public void OnConnectToDatabase_NoIntegratedSecurityAndMissingUsername_DisplayErrorMessage()
		{
			// arrange
			var presenter = new ConnectToSqlServerPresenter(_view.Object);

			_view.Setup(x => x.Server).Returns("server");
			_view.Setup(x => x.Database).Returns("db");
			_view.Setup(x => x.UseIntegratedSecurity).Returns(false);
			_view.Setup(x => x.Username).Returns(string.Empty);

			// act
			_view.Raise(x => x.OnConnectToDatabase += null, new EventArgs());

			// assert
			_view.Verify(x => x.DisplayErrorMessage("Not all required fields have values"), Times.Once());
		}
	}
}
