using System.IO;
using ElmahLogAnalyzer.Core.Domain.Export;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain.Export
{
    [TestFixture] [Ignore("Unable to load the native components of SQL Server Compact")]
    public class SqlCeDatabaseCreatorTests : IntegrationTestBase
	{
		private readonly string _databaseFilename = Path.Combine(Directory.GetCurrentDirectory(), "Test.sdf");

		[Test]
		public void Create_CreatesDatabaseFile()
		{
			// arrange
			var creator = CreateCreator();

			// act
			creator.Create(_databaseFilename);

			// assert
			Assert.That(File.Exists(_databaseFilename));
		}

		[Test]
		public void Create_DatabaseFileExists_Overwrite()
		{
			// arrange
			var creator = CreateCreator();

			using (var s = File.CreateText(_databaseFilename))
			{
				s.WriteLine("dummy");
			}

			var dummyFileSize = new FileInfo(_databaseFilename).Length;

			// act
			creator.Create(_databaseFilename);

			// assert
			Assert.That(File.Exists(_databaseFilename));

			var databaseFileSize = new FileInfo(_databaseFilename).Length;
			Assert.That(databaseFileSize, Is.GreaterThan(dummyFileSize));
		}

		private static SqlCeDatabaseCreator CreateCreator()
		{
			return new SqlCeDatabaseCreator(new FileSystemHelper(), new FakeLog());
		}
	}
}
