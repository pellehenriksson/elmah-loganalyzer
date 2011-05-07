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
			var errorlog = CreateFakeErrorLog();
			var builder = new YellowScreenOfDeathBuilder(errorlog);
			
			// assert
			Assert.That(builder.ErrorLog, Is.EqualTo(errorlog));
		}

		[Test]
		public void GetHtml_BuildHtmlContent()
		{
			// arrange
			var errorlog = CreateFakeErrorLog();
			var builder = new YellowScreenOfDeathBuilder(errorlog);

			// act
			var result = builder.GetHtml();

			// assert
			Assert.That(result, Is.Not.Null);
		}
	}
}
