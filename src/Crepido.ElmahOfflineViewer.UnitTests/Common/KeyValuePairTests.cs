using Crepido.ElmahOfflineViewer.Core.Common;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Common
{
	[TestFixture]
	public class KeyValuePairTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsNameAndValue()
		{
			// act
			var pair = new KeyValuePair("name", "value");

			// assert
			Assert.That(pair.Name, Is.EqualTo("name"));
			Assert.That(pair.Value, Is.EqualTo("value"));
		}
	}
}
