using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Presentation
{
	[TestFixture]
	public class ErrorLogSelectedEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_ShouldSetErrorLog()
		{
			// arrange
			var error = new ErrorLog();

			// act
			var args = new ErrorLogSelectedEventArgs(error);

			// assert
			Assert.That(args.ErrorLog, Is.EqualTo(error));
		}
	}
}
