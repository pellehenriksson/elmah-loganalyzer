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
			var item = new ReportTypeListItem(ReportTypeEnum.Url);

			// assert
			Assert.That(item.ReportType, Is.EqualTo(ReportTypeEnum.Url));
			Assert.That(item.Displayname, Is.EqualTo(ReportTypeEnum.Url.GetDescription()));
		}

		[Test]
		public void ToString_IsDisplayname()
		{
			// arrange
			var item = new ReportTypeListItem(ReportTypeEnum.Url);

			// act
			var result = item.ToString();

			// assert
			Assert.That(result, Is.EqualTo(item.Displayname));
		}
	}
}
