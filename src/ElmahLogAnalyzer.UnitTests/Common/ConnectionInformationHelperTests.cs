using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
	[TestFixture]
	public class ConnectionInformationHelperTests : UnitTestBase
	{
		[Test]
		public void GetInformation_SourceIsFiles()
		{
			// act
			var result = ConnectionInformationHelper.GetInformation(ErrorLogSources.Files, @"c:\temp\elmahlogs");

			// assert
			Assert.That(result, Is.EqualTo(@"Connected to directory: c:\temp\elmahlogs"));
		}

		[Test]
		public void GetInformation_SourceIsSqlServerWithIntegratedSecurity()
		{
			// act
			var result = ConnectionInformationHelper.GetInformation(ErrorLogSources.SqlServer, @"Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;");

			// assert
			Assert.That(result, Is.EqualTo(@"Connected to Microsoft SQL Server: Data Source=myServerAddress Initial Catalog=myDataBase"));
		}

		[Test]
		public void GetInformation_SourceIsSqlServerWithPassword()
		{
			// act
			var result = ConnectionInformationHelper.GetInformation(ErrorLogSources.SqlServer, @"Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;");

			// assert
			Assert.That(result, Is.EqualTo(@"Connected to Microsoft SQL Server: Data Source=myServerAddress Initial Catalog=myDataBase"));
		}

		[Test]
		public void GetInformation_SourceIsSqlServerCompact()
		{
			// act
			var result = ConnectionInformationHelper.GetInformation(ErrorLogSources.SqlServerCompact, @"Data Source=MyData.sdf");

			// assert
			Assert.That(result, Is.EqualTo(@"Connected to Microsoft SQL Server Compact Edition: Data Source=MyData.sdf"));
		}
	}
}
