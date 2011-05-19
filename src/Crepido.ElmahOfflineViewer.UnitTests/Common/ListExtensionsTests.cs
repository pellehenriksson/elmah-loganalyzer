using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Common;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Common
{
	[TestFixture]
	public class ListExtensionsTests : UnitTestBase
	{
		[Test]
		public void InvertedContains_Include_ItemExistsInList_True()
		{
			// arrange
			var list = new List<string> { "a", "b", "c" };
			
			// assert
			Assert.That(list.InvertedContains("a", true), Is.True);
		}

		[Test]
		public void InvertedContains_Include_ItemDoesNotExistsInList_False()
		{
			// arrange
			var list = new List<string> { "a", "b", "c" };

			// assert
			Assert.That(list.InvertedContains("x", true), Is.False);
		}

		[Test]
		public void InvertedContains_Exclude_ItemExistsInList_False()
		{
			// arrange
			var list = new List<string> { "a", "b", "c" };

			// assert
			Assert.That(list.InvertedContains("a", false), Is.False);
		}

		[Test]
		public void InvertedContains_Exclude_ItemDoesNotExistsInList_True()
		{
			// arrange
			var list = new List<string> { "a", "b", "c" };

			// assert
			Assert.That(list.InvertedContains("x", false), Is.True);
		}
	}
}
