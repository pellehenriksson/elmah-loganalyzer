using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
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
