﻿using System;
using System.IO;
using ElmahLogAnalyzer.Core.Domain.Export;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain.Export
{
    [TestFixture] [Ignore("Unable to load the native components of SQL Server Compact")]
    public class ErrorLogExporterTests : IntegrationTestBase
	{
		[Test]
		public void Export_Completed_RaisesCompletedEventArgs()
		{
            // arrange
            var databaseFilename = Path.Combine(TestFilesDirectory, "Test.sdf");
            var repository = CreateRepository(maxNumberOfLogs: 1);
			var fileSystemHelper = new FileSystemHelper();
			var databaseCreator = new SqlCeDatabaseCreator(fileSystemHelper, new FakeLog());
			var exporter = new ErrorLogExporter(repository, databaseCreator);

			repository.Initialize();

			// act
			var eventWasRaised = false;
			exporter.OnCompleted += delegate { eventWasRaised = true; };

			exporter.Export(databaseFilename);

			// assert
			Assert.That(eventWasRaised, Is.True);
		}

		[Test]
		public void Export_ProgressChanged_RaisesProgressChangedEventArgs()
		{
            // arrange
            var databaseFilename = Path.Combine(TestFilesDirectory, "Test.sdf");
            var repository = CreateRepository(maxNumberOfLogs: 1);
			var fileSystemHelper = new FileSystemHelper();
			var databaseCreator = new SqlCeDatabaseCreator(fileSystemHelper, new FakeLog());
			var exporter = new ErrorLogExporter(repository, databaseCreator);

			repository.Initialize();

			// act
			var eventWasRaised = false;
			exporter.OnProgressChanged += delegate(object sender, ErrorLogExporterProgressEventArgs args)
			                              	{
			                              		eventWasRaised = true;
												Assert.That(args.Progress, Is.EqualTo("Exporting error log 1 of 1"));
			                              	};

			exporter.Export(databaseFilename);

			// assert
			Assert.That(eventWasRaised, Is.True);
		}

		[Test]
		public void Export_ErrorOccurred_RaisesErrorEventArgs()
		{
            // arrange
            var databaseFilename = Path.Combine(TestFilesDirectory, "Test.sdf");
            var repository = CreateRepository(maxNumberOfLogs: 1);
			var fileSystemHelper = new Mock<IFileSystemHelper>();
			var databaseCreator = new SqlCeDatabaseCreator(fileSystemHelper.Object, new FakeLog());
			var exporter = new ErrorLogExporter(repository, databaseCreator);

			repository.Initialize();

			var error = new InvalidOperationException();
			fileSystemHelper.Setup(x => x.FileExists(It.IsAny<string>())).Throws(error);

			// act
			var eventWasRaised = false;
			exporter.OnError += delegate(object sender, ErrorLogExporterErrorEventArgs args)
			                    	{
			                    		eventWasRaised = true;
										Assert.That(args.Error, Is.EqualTo(error));
			                    	};

			exporter.Export(databaseFilename);

			// assert
			Assert.That(eventWasRaised, Is.True);
		}
	}
}
