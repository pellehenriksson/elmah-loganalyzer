using ElmahLogAnalyzer.Core.Domain.Export;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain.Export
{
	[TestFixture]
	public class ErrorLogExporterTests : IntegrationTestBase
	{
		[Test]
		public void Export_InsertsErrorLogs()
		{
			// arrange
			var repository = CreateRepository();
			var fileSystemHelper = new FileSystemHelper();
			var exporter = new ErrorLogExporter(repository, fileSystemHelper, new FakeConsoleLog());

			repository.Initialize(TestFilesDirectory);

			// act
			var logsImported = exporter.Export();

			// assert
			Assert.That(logsImported, Is.EqualTo(20));
		}

		[Test][Ignore]
		public void Export_InsertsManyErrorLogs()
		{
			// arrange
			var repository = CreateRepository();
			var fileSystemHelper = new FileSystemHelper();
			var exporter = new ErrorLogExporter(repository, fileSystemHelper, new FakeConsoleLog());

			repository.Initialize(@"c:\temp\elmah");

			// act
			var logsImported = exporter.Export();

			// assert
			Assert.That(logsImported, Is.EqualTo(13099));
		}
	}
}
