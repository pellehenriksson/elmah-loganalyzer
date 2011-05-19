using Crepido.ElmahOfflineViewer.Core.Common;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Common
{
	[TestFixture]
	public class UniqueStringListTests : UnitTestBase
	{
		[Test]
		public void Ctor_HasEmptyList()
		{
			// arrange
			var list = new UniqueStringList();
			
			// assert
			Assert.That(list.List.Count, Is.EqualTo(0));
		}

		[Test]
		public void Add_ItemIsNotNullOrEmpty_Added()
		{
			// arrange
			var list = new UniqueStringList();

			// act
			list.Add("some item");

			// assert
			Assert.That(list.List.Count, Is.EqualTo(1));
		}

		[Test]
		public void Add_ItemIsNull_NotAdded()
		{
			// arrange
			var list = new UniqueStringList();

			// act
			list.Add(null);

			// assert
			Assert.That(list.List.Count, Is.EqualTo(0));
		}

		[Test]
		public void Add_ItemIsEmptyString_NotAdded()
		{
			// arrange
			var list = new UniqueStringList();

			// act
			list.Add(string.Empty);

			// assert
			Assert.That(list.List.Count, Is.EqualTo(0));
		}

		[Test]
		public void Add_ItemIsWhitespace_NotAdded()
		{
			// arrange
			var list = new UniqueStringList();

			// act
			list.Add("   ");

			// assert
			Assert.That(list.List.Count, Is.EqualTo(0));
		}

		[Test]
		public void List_ReturnsList()
		{
			// arrange
			var list = new UniqueStringList();

			list.Add("a");
			list.Add("b");
			list.Add("c");

			// act
			var result = list.List;

			// assert
			Assert.That(result.Count, Is.EqualTo(3));
		}

		[Test]
		public void List_IsSorted()
		{
			// arrange
			var list = new UniqueStringList();

			list.Add("c");
			list.Add("b");
			list.Add("a");

			// act
			var result = list.List;

			// assert
			Assert.That(result[0], Is.EqualTo("a"));
			Assert.That(result[1], Is.EqualTo("b"));
			Assert.That(result[2], Is.EqualTo("c"));
		}

		[Test]
		public void Clear_RemovesAllItems()
		{
			// arrange
			var list = new UniqueStringList();

			list.Add("a");
			list.Add("b");
			list.Add("c");

			// act
			list.Clear();

			// assert
			Assert.That(list.List.Count, Is.EqualTo(0));
		}

		[Test]
		public void Add_ListAllowsEmptyValue_AddsValue()
		{
			// arrange
			var list = new UniqueStringList(true);

			// act
			list.Add(string.Empty);

			// assert
			Assert.That(list.List.Count, Is.EqualTo(1));
		}
	}
}
