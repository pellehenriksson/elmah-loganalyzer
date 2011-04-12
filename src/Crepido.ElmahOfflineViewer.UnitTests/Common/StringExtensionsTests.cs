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
			var value = string.Empty;

			// assert
			Assert.That(value.HasValue(), Is.False);
		}
		
		[Test]
		public void HasValue_IsOnlyWhiteSpace_IsFalse()
		{
			// arrange
			const string value = "  ";

			// assert
			Assert.That(value.HasValue(), Is.False);
		}

		[Test]
		public void HasValue_HasValue_IsTrue()
		{
			// arrange
			const string value = "hello world";

			// assert
			Assert.That(value.HasValue(), Is.True);
		}

		[Test]
		public void ContainsText_IsNull_IsFalse()
		{
			// arrange
			string value = null;

			// assert
			Assert.That(value.ContainsText("text"), Is.False);
		}

		[Test]
		public void ContainsText_IsEmpty_IsFalse()
		{
			// arrange
			var value = string.Empty;

			// assert
			Assert.That(value.ContainsText("text"), Is.False);
		}
		
		[Test]
		public void ContainsText_IsOnlyWhiteSpace_IsFalse()
		{
			// arrange
			const string value = "  ";

			// assert
			Assert.That(value.ContainsText("text"), Is.False);
		}

		[Test]
		public void ContainsText_DoesNotContainsText_IsFalse()
		{
			// arrange
			const string value = "hello world";

			// assert
			Assert.That(value.ContainsText("text"), Is.False);
		}

		[Test]
		public void ContainsText_ContainsText_IsTrue()
		{
			// arrange
			const string value = "hello world";

			// assert
			Assert.That(value.ContainsText("world"), Is.True);
		}
	}
}
