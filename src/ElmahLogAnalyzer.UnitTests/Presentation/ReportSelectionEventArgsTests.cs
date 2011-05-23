using ElmahLogAnalyzer.Core.Presentation;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ReportSelectionEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsReportQuery()
		{
			// arrange
			var query = CreateReportQuery();

			// act
			var args = new ReportSelectionEventArgs(query);

			// assert
			Assert.That(args.Query, Is.EqualTo(query));
		}
	}
}
