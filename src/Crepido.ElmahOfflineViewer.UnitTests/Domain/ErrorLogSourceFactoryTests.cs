using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ErrorLogSourceFactoryTests : UnitTestBase
	{
		[Test]
		public void Build_PathIsDirectory_ReturnsFileErrorLogSourceService()
		{
			// act
			var service = new ErrorLogSourceFactory().Build(@"c:\temp\elmah");

			// assert
			Assert.That(service, Is.TypeOf(typeof(FileErrorLogSource)));
		}

		[Test]
		public void Build_PathIsConnectionString_ReturnsSqlServerErrorLogSourceService()
		{
			// act
			var service = new ErrorLogSourceFactory().Build("Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;");

			// assert
			Assert.That(service, Is.TypeOf(typeof(SqlServerErrorLogSource)));
		}
	}
}
