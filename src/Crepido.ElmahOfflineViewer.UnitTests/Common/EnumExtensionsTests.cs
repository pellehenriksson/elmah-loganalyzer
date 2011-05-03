using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.TestHelpers;
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
			const TestEnum type = TestEnum.ValueWithDescriptionAttribute;

			// act
			var result = type.GetDescription();

			// assert
			Assert.That("Hello world", Is.EqualTo(result));
		}

		[Test]
		public void GetDescription_HasNoAttribute_ReturnsEnumValueName()
		{
			// arrange
			const TestEnum type = TestEnum.ValueWithNoDescriptionAttribute;

			// act
			var result = type.GetDescription();

			// assert
			Assert.That("ValueWithNoDescriptionAttribute", Is.EqualTo(result));
		}
	}
}
