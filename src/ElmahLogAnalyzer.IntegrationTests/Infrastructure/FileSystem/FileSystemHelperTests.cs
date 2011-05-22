using System.IO;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Infrastructure.FileSystem
{
	[TestFixture]
	public class FileSystemHelperTests : IntegrationTestBase
	{
		[Test]
		public void DirectoryExists_DirectoryDoesExist_ReturnsTrue()
		{
			// arrange
			var helper = new FileSystemHelper();

			// act
			var result = helper.DirectoryExists(Directory.GetCurrentDirectory());

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void DirectoryExists_DirectoryDoesNotExist_ReturnsFalse()
		{
			// arrange
			var helper = new FileSystemHelper();

			// act
			var result = helper.DirectoryExists("x:\\bluttanbla");

			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void GetFilesFromDirectory_ReturnsAllFilenamesThatMatchesPattern()
		{
			// arrange
			var helper = new FileSystemHelper();

			// act
			var result = helper.GetFilesFromDirectory(TestFilesDirectory, "error-*.xml");

			// assert
			Assert.That(result.Length, Is.EqualTo(20));
		}

		[Test]
		public void GetFileContent_FileExists_ReturnsContent()
		{
			// arrange
			var helper = new FileSystemHelper();
			var file = Path.Combine(TestFilesDirectory, "error-2011-04-10142706Z-d0da432d-fd3c-45b6-baf1-2cf49a5724e8.xml");

			// act
			var result = helper.GetFileContent(file);

			// assert
			Assert.That(result.Length, Is.GreaterThanOrEqualTo(1));
		}

		[Test]
		public void GetCurrentDirectory_ReturnsTheCurrentDirectory()
		{
			// arrange
			var helper = new FileSystemHelper();

			// act
			var result = helper.GetCurrentDirectory();

			// assert
			Assert.That(result, Is.EqualTo(Directory.GetCurrentDirectory()));
		}

		[Test]
		public void FileExists_FileExists_ReturnsTrue()
		{
			// arrange
			var helper = new FileSystemHelper();
			var file = Path.Combine(TestFilesDirectory, "error-2011-04-10142706Z-d0da432d-fd3c-45b6-baf1-2cf49a5724e8.xml");

			// act
			var result = helper.FileExists(file);

			// assert
			Assert.That(result, Is.True);
		}
		
		[Test]
		public void FileExists_FileDoesNotExist_ReturnsFalse()
		{
			// arrange
			var helper = new FileSystemHelper();
			var file = Path.Combine(TestFilesDirectory, "nonexistantfile.xml");

			// act
			var result = helper.FileExists(file);

			// assert
			Assert.That(result, Is.False);
		}
	}
}
