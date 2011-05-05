using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class YellowScreenOfDeathBuilderTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsErrorLog()
		{
			// arrange
			var errorlog = FakeErrorLog;
			var builder = new YellowScreenOfDeathBuilder(errorlog);
			
			// assert
			Assert.That(builder.ErrorLog, Is.EqualTo(errorlog));
		}

		[Test]
		public void Build_BuildHtmlContent()
		{
			// arrange

			// act

			// assert
		}
	}
}
