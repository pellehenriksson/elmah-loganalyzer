using System.IO;
using ElmahLogAnalyzer.Core.Domain.Export;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain.Export
{
	[TestFixture]
	public class DatabaseExporterTests : IntegrationTestBase
	{
		[Test]
		public void CreateStorage_DatabaseDoesNotExist_ShouldCreateDatabase()
		{
			// arrange
			var repository = CreateRepository();
			var fileSystemHelper = new FileSystemHelper();
			
			var exporter = new DatabaseExporter(repository, fileSystemHelper);

			// act
			exporter.CreateStorage("Test_Database");

			// assert
			var database = Path.Combine(Directory.GetCurrentDirectory(), "Test_Database.sdf");
			Assert.That(File.Exists(database));
		}

		[Test]
		public void CreateStorage_DatabaseExists_ShouldDeleteExistingAndCreateNew()
		{
			// arrange
			var repository = CreateRepository();
			var fileSystemHelper = new FileSystemHelper();
			var exporter = new DatabaseExporter(repository, fileSystemHelper);
			
			exporter.CreateStorage("Test_Database1");
			
			// act
			exporter.CreateStorage("Test_Database1");

			// assert
			var database = Path.Combine(Directory.GetCurrentDirectory(), "Test_Database1.sdf");
			Assert.That(File.Exists(database));
		}

		[Test]
		public void Export_InsertsErrorLogs()
		{
			// arrange
			var repository = CreateRepository();
			var fileSystemHelper = new FileSystemHelper();
			var exporter = new DatabaseExporter(repository, fileSystemHelper);

			exporter.CreateStorage("Test");
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
			var exporter = new DatabaseExporter(repository, fileSystemHelper);

			exporter.CreateStorage("Test");
			repository.Initialize(@"c:\temp\elmah");

			// act
			var logsImported = exporter.Export();

			// assert
			Assert.That(logsImported, Is.EqualTo(13099));
		}
	}
}
