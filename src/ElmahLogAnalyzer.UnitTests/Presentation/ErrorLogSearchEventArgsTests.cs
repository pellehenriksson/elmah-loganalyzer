using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
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
