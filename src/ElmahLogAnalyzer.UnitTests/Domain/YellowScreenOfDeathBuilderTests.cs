using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.TestHelpers;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class YellowScreenOfDeathBuilderTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsErrorLog()
		{
			// arrange
			var errorlog = DomainObjectBuilder.CreateFakeErrorLog();
			var builder = new YellowScreenOfDeathBuilder(errorlog);
			
			// assert
			Assert.That(builder.ErrorLog, Is.EqualTo(errorlog));
		}

		[Test]
		public void GetHtml_BuildHtmlContent()
		{
			// arrange
			var errorlog = DomainObjectBuilder.CreateFakeErrorLog();
			var builder = new YellowScreenOfDeathBuilder(errorlog);

			// act
			var result = builder.GetHtml();

			// assert
			Assert.That(result, Is.Not.Null);
		}
	}
}
