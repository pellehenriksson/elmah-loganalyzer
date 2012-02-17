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
		public void Ctor_SetsPresenter()
		{
			// act
			var presenter = new ConnectToSqlServerPresenter(_view.Object);

			// assert
			Assert.That(presenter.View, Is.EqualTo(_view.Object));
		}
	}
}
