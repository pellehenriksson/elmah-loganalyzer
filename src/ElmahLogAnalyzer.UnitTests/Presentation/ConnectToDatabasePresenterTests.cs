using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ConnectToDatabasePresenterTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsView()
		{
			// arrange
			var view = new Mock<IConnectToDatabaseView>();

			// act
			var presenter = new ConnectToDatabasePresenter(view.Object);

			// assert
			Assert.That(presenter.View, Is.EqualTo(view.Object));
		}
	}
}
