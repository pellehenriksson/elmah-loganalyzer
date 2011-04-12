using System;
using System.IO;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.IntegrationTests.Domain
{
	[TestFixture]
	public class DataSourceServiceTests
	{
		[Test]
		public void GetLogs_ShouldReturnParsedFilesFromDisk()
		{
			// arrange
			var source = new DataSourceService(new ErrorLogFileParser());

			// act
			var result = source.GetLogs(Directory.GetCurrentDirectory());

			// assert
			Assert.That(result.Count, Is.EqualTo(20));
		}

		[Test]
		public void GetLog_DirectoryDoesNotExist_ThrowsApplicationException()
		{
			// arrange
			var source = new DataSourceService(new ErrorLogFileParser());

			// act
			var result = Assert.Throws<ApplicationException>(() => source.GetLogs(@"x:\invalid\directory"));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.Message, Is.EqualTo(@"The directory: x:\invalid\directory was not found"));
		}
	}
}
