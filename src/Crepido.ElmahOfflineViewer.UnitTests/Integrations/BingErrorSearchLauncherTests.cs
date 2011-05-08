using System;
using Crepido.ElmahOfflineViewer.Core.Integrations;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations
{
	[TestFixture]
	public class BingErrorSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Ctor_ErrorLogIsNull_Throws()
		{
			// act
			var result = Assert.Throws<ArgumentNullException>(() => new BingErrorSearchLauncher(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("errorLog"));
		}

		[Test]
		public void Ctor_SetsErrorLog()
		{
			// arrange
			var errorLog = CreateFakeErrorLog();
			
			// act
			var launcher = new BingErrorSearchLauncher(errorLog);

			// assert
			Assert.That(launcher.ErrorLog, Is.EqualTo(errorLog));
		}

		[Test]
		public void Ctor_BuildUrlWithTypeAndSourceAsParameters()
		{
			// arrange
			var errorLog = CreateFakeErrorLog();
			var launcher = new BingErrorSearchLauncher(errorLog);

			// act
			var result = launcher.BuildSearchUrl();
			
			// assert
			Assert.That(result, Is.EqualTo("http://www.bing.com/search?q=System.InvalidOperationException+System.Web.Mvc"));
		}
	}
}
