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
		public void Build_ErrorLogSourcesIsSqlServerWithIntegratedSecurity()
		{
			// arrange
			var connect = new Mock<IConnectToDatabase>();
			connect.Setup(x => x.Source).Returns(ErrorLogSourcesEnum.SqlServer);
			connect.Setup(x => x.Server).Returns("myServerAddress");
			connect.Setup(x => x.Database).Returns("myDataBase");
			connect.Setup(x => x.UseIntegratedSecurity).Returns(true);

			// act
			var result = ConnectionStringBuilder.Build(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo("Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;"));
		}

		[Test]
		public void Build_ErrorLogSourcesIsSqlServerWithUsernameAndPassword()
		{
			// arrange
			var connect = new Mock<IConnectToDatabase>();
			connect.Setup(x => x.Source).Returns(ErrorLogSourcesEnum.SqlServer);
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
		public void Build_ErrorLogSourcesIsSqlServerCompact()
		{
			// arrange
			var connect = new Mock<IConnectToDatabase>();
			connect.Setup(x => x.Source).Returns(ErrorLogSourcesEnum.SqlServer);
			connect.Setup(x => x.File).Returns(@"c:\temp\elmah.sdf");

			// act
			var result = ConnectionStringBuilder.Build(connect.Object);

			// assert
			Assert.That(result, Is.EqualTo(@"Data Source=c:\temp\elmah.sdf;Persist Security Info=False;"));
		}
	}
}
