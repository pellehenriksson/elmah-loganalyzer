using System;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
	[TestFixture]
	public class ConnectionStringHelperTests
	{
		[Test]
		public void Extract_ErrorLogSourceIsSqlServerWithIntegratedSecurity()
		{
			// arrange
			var connect = new Mock<IConnectToDatabaseConnectionInformation>();
			connect.Setup(x => x.Source).Returns(ErrorLogSources.SqlServer);
			connect.Setup(x => x.Server).Returns("myServerAddress");
			connect.Setup(x => x.Database).Returns("myDataBase");
			connect.Setup(x => x.UseIntegratedSecurity).Returns(true);

			// act
			var result = ConnectionStringHelper.Extract(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo("Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;"));
		}

		[Test]
		public void Extract_ErrorLogSourceIsSqlServerWithUsernameAndPassword()
		{
			// arrange
			var connect = new Mock<IConnectToDatabaseConnectionInformation>();
			connect.Setup(x => x.Source).Returns(ErrorLogSources.SqlServer);
			connect.Setup(x => x.Server).Returns("myServerAddress");
			connect.Setup(x => x.Database).Returns("myDataBase");
			connect.Setup(x => x.Username).Returns("myUsername");
			connect.Setup(x => x.Password).Returns("myPassword");
			connect.Setup(x => x.UseIntegratedSecurity).Returns(false);

			// act
			var result = ConnectionStringHelper.Extract(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo("Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;"));
		}

		[Test]
		public void Extract_ErrorLogSourceIsSqlServerCompact()
		{
			// arrange
			var connect = new Mock<IConnectToDatabaseConnectionInformation>();
			connect.Setup(x => x.Source).Returns(ErrorLogSources.SqlServerCompact);
			connect.Setup(x => x.Server).Returns(@"c:\temp\elmah.sdf");

			// act
			var result = ConnectionStringHelper.Extract(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo(@"Data Source=c:\temp\elmah.sdf;Persist Security Info=False;"));
		}

		[Test]
		public void Extract_ErrorLogSourceIsAccess()
		{
			// arrange
			var connect = new Mock<IConnectToDatabaseConnectionInformation>();
			connect.Setup(x => x.Source).Returns(ErrorLogSources.Access);
			connect.Setup(x => x.Server).Returns(@"c:\temp\elmah.mdb");

			// act
			var result = ConnectionStringHelper.Extract(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\temp\elmah.mdb;"));
		}

		[Test]
		public void Extract_ErrorLogSourceIsFiles_Throws()
		{
			// arrange
			var connect = new Mock<IConnectToDatabaseConnectionInformation>();
			connect.Setup(x => x.Source).Returns(ErrorLogSources.Files);

			// act
			var result = Assert.Throws<InvalidOperationException>(() => ConnectionStringHelper.Extract(connect.Object));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.Message, Is.EqualTo("Error log source Files is not supported"));
		}

		[Test]
		public void Apply_SetsSqlServerConnectionStringWithUsernameAndPasswordParameterValuesOnInterface()
		{
			// arrage
			var information = new Mock<IConnectToDatabaseConnectionInformation>();
			var cn = "Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;";

			// act
			ConnectionStringHelper.Apply(information.Object, cn);

			// assert
			information.VerifySet(x => x.Server = "myServerAddress");
			information.VerifySet(x => x.Database = "myDataBase");
			information.VerifySet(x => x.Username = "myUsername");
			information.VerifySet(x => x.Password = "myPassword");
		}

		[Test]
		public void Apply_SetsSqlServerConnectionStringWithIntegratedSecurityParameterValuesOnInterface()
		{
			// arrage
			var information = new Mock<IConnectToDatabaseConnectionInformation>();
			var cn = "Server=myServerAddress;Database=myDataBase;Integrated Security=SSPI;";

			// act
			ConnectionStringHelper.Apply(information.Object, cn);

			// assert
			information.VerifySet(x => x.Server = "myServerAddress");
			information.VerifySet(x => x.Database = "myDataBase");
			information.VerifySet(x => x.UseIntegratedSecurity = true);
		}
		
		[Test]
		public void Apply_SetsSqlServerCompactConnectionStringValuesOnInterface()
		{
			// arrage
			var information = new Mock<IConnectToDatabaseConnectionInformation>();
			var cn = @"Data Source=c:\temp\elmah.sdf;";

			// act
			ConnectionStringHelper.Apply(information.Object, cn);

			// assert
			information.VerifySet(x => x.Server = @"c:\temp\elmah.sdf");
		}
	}
}
