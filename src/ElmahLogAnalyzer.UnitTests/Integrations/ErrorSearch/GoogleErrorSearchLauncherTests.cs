using System;
using ElmahLogAnalyzer.Core.Integrations.ErrorSearch;
using ElmahLogAnalyzer.TestHelpers;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Integrations.ErrorSearch
{
	[TestFixture]
	public class GoogleErrorSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Launch_BuildUrlAndLaunch()
		{
			// arrange
			var starter = new FakeUrlNavigationLauncher();
			var launcher = new GoogleErrorSearchLauncher(starter);
			var errorLog = DomainObjectBuilder.CreateFakeErrorLog();

			// act
			launcher.Launch(errorLog);

			// assert
			Assert.That(starter.RunWithUrl, Is.EqualTo(new Uri("http://www.google.com/search?q=System.InvalidOperationException+System.Web.Mvc")));
		}
	}
}
