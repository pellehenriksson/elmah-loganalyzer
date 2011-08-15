using System.IO;
using ElmahLogAnalyzer.Core.Domain.Export;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain.Export
{
	[TestFixture]
	public class SqlCeDatabaseCreatorTests : IntegrationTestBase
	{
		private const string DatabaseFilename = "Test.sdf";

		[Test]
		public void Create_CreatesDatabaseFile()
		{
			// arrange
			var creator = CreateCreator();

			// act
			creator.Create(DatabaseFilename);

			// assert
			Assert.That(File.Exists(DatabaseFilename));
		}

		[Test]
		public void Create_DatabaseFileExists_Overwrite()
		{
			// arrange
			var creator = CreateCreator();

			using (var s = File.CreateText(DatabaseFilename))
			{
				s.WriteLine("dummy");
			}

			var dummyFileSize = new FileInfo(DatabaseFilename).Length;

			// act
			creator.Create(DatabaseFilename);

			// assert
			Assert.That(File.Exists(DatabaseFilename));

			var databaseFileSize = new FileInfo(DatabaseFilename).Length;
			Assert.That(databaseFileSize, Is.GreaterThan(dummyFileSize));
		}

		private static SqlCeDatabaseCreator CreateCreator()
		{
			return new SqlCeDatabaseCreator(new FileSystemHelper(), new FakeLog());
		}
	}
}
