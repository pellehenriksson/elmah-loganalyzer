using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.IntegrationTests.Infrastructure
{
	[TestFixture]
	public class CacheHelperTests
	{
		[Test]
		public void Get_NotInCache_ReturnsNull()
		{
			// arrange
			var helper = new CacheHelper();

			// act
			var result = helper.Get<Dictionary<string, string>>("somekey");

			// assert
			Assert.That(result, Is.Null);
		}

		[Test]
		public void Get_InCache_ReturnsCachedItem()
		{
			// arrange
			var helper = new CacheHelper();

			var dictionary = new Dictionary<string, string>();

			helper.Set("someotherkey", dictionary);

			// act
			var result = helper.Get<Dictionary<string, string>>("someotherkey");

			// assert
			Assert.That(result, Is.EqualTo(dictionary));
		}
	}
}
