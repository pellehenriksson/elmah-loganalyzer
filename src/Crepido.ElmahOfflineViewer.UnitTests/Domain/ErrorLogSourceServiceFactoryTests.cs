using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ErrorLogSourceServiceFactoryTests : UnitTestBase
	{
		[Test]
		public void Build_PathIsDirectory_ReturnsFileErrorLogSourceService()
		{
			// act
			var service = new ErrorLogSourceServiceFactory().Build(@"c:\temp\elmah");

			// assert
			Assert.That(service, Is.TypeOf(typeof(FileErrorLogSourceService)));
		}

		[Test]
		public void Build_PathIsConnectionString_ReturnsSqlServerErrorLogSourceService()
		{
			// act
			var service = new ErrorLogSourceServiceFactory().Build("Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;");

			// assert
			Assert.That(service, Is.TypeOf(typeof(SqlServerErrorLogSourceService)));
		}
	}
}
