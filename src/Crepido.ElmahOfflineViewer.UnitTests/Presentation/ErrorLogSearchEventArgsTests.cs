using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Presentation
{
	[TestFixture]
	public class ErrorLogSearchEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsQuery()
		{
			// arrange
			var query = new SearchErrorLogQuery();

			// act
			var args = new ErrorLogSearchEventArgs(query);

			// assert
			Assert.That(args.Query, Is.EqualTo(query));
		}
	}
}
