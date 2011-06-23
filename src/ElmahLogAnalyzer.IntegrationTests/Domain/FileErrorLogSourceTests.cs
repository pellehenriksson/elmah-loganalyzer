using System;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain
{
	[TestFixture]
	public class FileErrorLogSourceTests : IntegrationTestBase
	{
		[Test]
		public void GetLogs_ParsesAllLogsInDirectory()
		{
			// arrange
			var source = CreateSource();

			// act
			var result = source.GetLogs(TestFilesDirectory);

			// assert
			Assert.That(result.Count, Is.EqualTo(20));
		}
		
		[Test]
		public void GetLogs_MaxNumberOfLogsIsTen_ParsesTenLatestLogsInDirectory()
		{
			// arrange
			var settings = new FakeSettingsManager();
			settings.SetMaxNumberOfLogs(10);

			var source = new FileErrorLogSource(new FileSystemHelper(), new ErrorLogFileParser(new FakeLog(), new ClientInformationResolver()), settings, new FakeLog());

			// act
			var result = source.GetLogs(TestFilesDirectory);

			// assert
			Assert.That(result.Count, Is.EqualTo(10));
		}

		[Test]
		public void GetLogs_DirectoryDoesNotExist_ThrowsApplicationException()
		{
			// arrange
			var source = CreateSource();

			// act
			var result = Assert.Throws<ApplicationException>(() => source.GetLogs(@"x:\invalid\directory"));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.Message, Is.EqualTo(@"The directory: x:\invalid\directory was not found"));
		}

		private static FileErrorLogSource CreateSource()
		{
			return new FileErrorLogSource(new FileSystemHelper(), new ErrorLogFileParser(new FakeLog(), new ClientInformationResolver()), new FakeSettingsManager(), new FakeLog());
		}
	}
}
