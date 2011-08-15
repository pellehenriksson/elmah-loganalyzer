using ElmahLogAnalyzer.Core.Domain.Export;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain.Export
{
	[TestFixture]
	public class ErrorLogExporterProgressEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsProgress()
		{
			// arrange
			const string progress = "created table ErrorLogs";

			// act
			var args = new ErrorLogExporterProgressEventArgs(progress);

			// assert
			Assert.That(args.Progress, Is.EqualTo(progress));
		}
	}
}
