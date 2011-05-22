using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class SearchErrorLogQueryParameterTests : UnitTestBase
	{
		[Test]
		public void Ctor_HasEmptyItemsList()
		{
			// arrange
			var parameter = new SearchErrorLogQueryParameter();

			// assert
			Assert.That(parameter.Items.Count, Is.EqualTo(0));
		}

		[Test]
		public void Ctor_SetsInlcudeItemsAndItems()
		{
			// arrange
			var items = new List<string>();
			
			var parameter = new SearchErrorLogQueryParameter(true, items);

			// assert
			Assert.That(parameter.IncludeItems, Is.True);
			Assert.That(parameter.Items, Is.EqualTo(items));
		}
	}
}
