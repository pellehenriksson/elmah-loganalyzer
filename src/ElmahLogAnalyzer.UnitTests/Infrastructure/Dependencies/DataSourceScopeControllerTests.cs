using System;
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
			DataSourceScopeController.SetNewSource("file", @"c:\temp");

			// assert
			Assert.That("file", Is.EqualTo(DataSourceScopeController.Source));
			Assert.That(@"c:\temp", Is.EqualTo(DataSourceScopeController.Connection));
		}

		[Test]
		public void SetNewSource_ValidSource_NewInstanceOfKeepAliveIsCreated()
		{
			// arrange
			var keepalive1 = DataSourceScopeController.KeepAlive;

			// act
			DataSourceScopeController.SetNewSource("file", @"c:\temp");

			// assert
			Assert.That(keepalive1, Is.Not.SameAs(DataSourceScopeController.KeepAlive));
		}

		[Test]
		public void SetNewSource_SourceIsNull_Throws()
		{
			// act
			var result = Assert.Throws<InvalidOperationException>(() => DataSourceScopeController.SetNewSource(null, @"c:\temp"));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.Message, Is.EqualTo("The source is undefined"));
		}
	}
}
