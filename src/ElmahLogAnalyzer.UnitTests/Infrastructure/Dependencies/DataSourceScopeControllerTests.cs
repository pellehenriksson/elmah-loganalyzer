using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Dependencies;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Infrastructure.Dependencies
{
	[TestFixture]
	public class DataSourceScopeControllerTests : UnitTestBase
	{
		[Test]
		public void SetNewSource_SetsSourceAndConnection()
		{
			// act
			DataSourceScopeController.SetNewSource(ErrorLogSourcesEnum.Files, @"c:\temp");

			// assert
			Assert.That(ErrorLogSourcesEnum.Files, Is.EqualTo(DataSourceScopeController.Source));
			Assert.That(@"c:\temp", Is.EqualTo(DataSourceScopeController.Connection));
		}

		[Test]
		public void SetNewSource_ValidSource_NewInstanceOfKeepAliveIsCreated()
		{
			// arrange
			var keepalive1 = DataSourceScopeController.KeepAlive;

			// act
			DataSourceScopeController.SetNewSource(ErrorLogSourcesEnum.Files, @"c:\temp");

			// assert
			Assert.That(keepalive1, Is.Not.SameAs(DataSourceScopeController.KeepAlive));
		}
	}
}
