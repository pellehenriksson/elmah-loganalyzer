using Crepido.ElmahOfflineViewer.Core.Common;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Common
{
	[TestFixture]
	public class StringExtensionsTests : UnitTestBase
	{
		[Test]
		public void HasValue_IsNull_IsFalse()
		{
			// arrange
			string value = null;

			// assert
			Assert.That(value.HasValue(), Is.False);
		}

		[Test]
		public void HasValue_IsEmpty_IsFalse()
		{
			// arrange
			string value = string.Empty;

			// assert
			Assert.That(value.HasValue(), Is.False);
		}
		
		[Test]
		public void HasValue_IsOnlyWhiteSpace_IsFalse()
		{
			// arrange
			string value = "  ";

			// assert
			Assert.That(value.HasValue(), Is.False);
		}

		[Test]
		public void HasValue_HasValue_IsTrue()
		{
			// arrange
			string value = "hello world";

			// assert
			Assert.That(value.HasValue(), Is.True);
		}
	}
}
