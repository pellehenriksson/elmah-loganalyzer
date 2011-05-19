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
	}
}
