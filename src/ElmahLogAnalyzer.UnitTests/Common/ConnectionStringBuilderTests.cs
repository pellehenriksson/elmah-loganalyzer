using System;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
	[TestFixture]
	public class ConnectionStringBuilderTests
	{
		[Test]
		public void Build_ErrorLogSourceIsSqlServerWithIntegratedSecurity()
		{
			// arrange
			var connect = new Mock<IConnectToDatabaseConnectionInformation>();
			connect.Setup(x => x.Source).Returns(ErrorLogSources.SqlServer);
			connect.Setup(x => x.Server).Returns("myServerAddress");
			connect.Setup(x => x.Database).Returns("myDataBase");
			connect.Setup(x => x.UseIntegratedSecurity).Returns(true);

			// act
			var result = ConnectionStringBuilder.Build(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo("Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;"));
		}

		[Test]
		public void Build_ErrorLogSourceIsSqlServerWithUsernameAndPassword()
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
			var result = ConnectionStringBuilder.Build(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo("Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;"));
		}

		[Test]
		public void Build_ErrorLogSourceIsSqlServerCompact()
		{
			// arrange
			var connect = new Mock<IConnectToDatabaseConnectionInformation>();
			connect.Setup(x => x.Source).Returns(ErrorLogSources.SqlServerCompact);
			connect.Setup(x => x.File).Returns(@"c:\temp\elmah.sdf");

			// act
			var result = ConnectionStringBuilder.Build(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo(@"Data Source=c:\temp\elmah.sdf;Persist Security Info=False;"));
		}

		[Test]
		public void Build_ErrorLogSourceIsFiles_Throws()
		{
			// arrange
			var connect = new Mock<IConnectToDatabaseConnectionInformation>();
			connect.Setup(x => x.Source).Returns(ErrorLogSources.Files);

			// act
			var result = Assert.Throws<InvalidOperationException>(() => ConnectionStringBuilder.Build(connect.Object));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.Message, Is.EqualTo("Error log source Files is not supported"));
		}
	}
}
