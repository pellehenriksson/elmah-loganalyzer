using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Common
{
	[TestFixture]
	public class EnumExtensionsTests : UnitTestBase
	{
		[Test]
		public void GetDescription_HasAttribute_ReturnsAttributeValue()
		{
			// arrange
			var type = ReportTypeEnum.Url;

			// act
			var result = type.GetDescription();

			// assert
			Assert.That("Number of errors per url", Is.EqualTo(result));
		}
	}
}
