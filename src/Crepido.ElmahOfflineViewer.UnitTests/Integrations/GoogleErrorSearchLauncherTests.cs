using System;
using Crepido.ElmahOfflineViewer.Core.Integrations;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations
{
	[TestFixture]
	public class GoogleErrorSearchLauncherTests : UnitTestBase
	{
		[Test]
		public void Ctor_ErrorLogIsNull_Throws()
		{
			// act
			var result = Assert.Throws<ArgumentNullException>(() => new GoogleErrorSearchLauncher(null));

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
			var launcher = new GoogleErrorSearchLauncher(errorLog);

			// assert
			Assert.That(launcher.ErrorLog, Is.EqualTo(errorLog));
		}

		[Test]
		public void Ctor_BuildUrlWithTypeAndSourceAsParameters()
		{
			// arrange
			var errorLog = CreateFakeErrorLog();
			var launcher = new GoogleErrorSearchLauncher(errorLog);

			// act
			var result = launcher.BuildSearchUrl();

			// assert
			Assert.That(result, Is.EqualTo("http://www.google.com/search?q=System.InvalidOperationException+System.Web.Mvc"));
		}
	}
}
