using ElmahLogAnalyzer.Core.Common;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
	[TestFixture]
	public class NameValuePairTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsNameAndValue()
		{
			// act
			var pair = new NameValuePair("name", "value");

			// assert
			Assert.That(pair.Name, Is.EqualTo("name"));
			Assert.That(pair.Value, Is.EqualTo("value"));
		}
	}
}
