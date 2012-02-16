using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ReportTypeListItemTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsTypeAndDisplayname()
		{
			// act
			var item = new ReportTypeListItem(ReportTypes.Url);

			// assert
			Assert.That(item.ReportType, Is.EqualTo(ReportTypes.Url));
			Assert.That(item.Displayname, Is.EqualTo(ReportTypes.Url.GetDescription()));
		}

		[Test]
		public void ToString_IsDisplayname()
		{
			// arrange
			var item = new ReportTypeListItem(ReportTypes.Url);

			// act
			var result = item.ToString();

			// assert
			Assert.That(result, Is.EqualTo(item.Displayname));
		}
	}
}
