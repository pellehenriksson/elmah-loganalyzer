using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Presentation
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
