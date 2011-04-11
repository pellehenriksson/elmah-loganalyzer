using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.UnitTests._TestFiles;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ErrorLogFileParserTests : UnitTestBase
	{
		[Test]
		public void Parse_ReturnsErrorLogWithFileContent()
		{
			// arrange
			var parser = new ErrorLogFileParser();

			// act
			var result = parser.Parse(TestFilesHelper.GetError1());

			// assert
			Assert.That(result.ErrorId, Is.EqualTo("dce7f8f3-ac74-4ad9-9435-a344be794c7e"));
			Assert.That(result.Host, Is.EqualTo("ALVA"));
			Assert.That(result.User, Is.EqualTo(@"alva\per"));
			Assert.That(result.Url, Is.EqualTo("/"));
			Assert.That(result.Type, Is.EqualTo("System.Data.SqlClient.SqlException"));
			Assert.That(result.Message, Is.EqualTo("A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 26 - Error Locating Server/Instance Specified)"));
			Assert.That(result.Source, Is.EqualTo(".Net SqlClient Data Provider"));
			Assert.That(result.ServerVariables.Count > 0);
		}

		[Test]
		public void Parse_FileIsNotInCorrectFormat_ReturnsNull()
		{
			// arrange
			var parser = new ErrorLogFileParser();

			// act
			var result = parser.Parse(TestFilesHelper.GetInvalidErrorFile());
			
			// assert
			Assert.That(result, Is.Null);
		}
	}
}
