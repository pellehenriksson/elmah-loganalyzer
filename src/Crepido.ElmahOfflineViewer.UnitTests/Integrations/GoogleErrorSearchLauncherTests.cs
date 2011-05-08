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
			// arrange
			var launcher = new GoogleErrorSearchLauncher();

			// act
			var result = Assert.Throws<ArgumentNullException>(() => launcher.Search(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("errorLog"));
		}
	}
}
