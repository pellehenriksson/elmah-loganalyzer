using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
	[TestFixture]
	public class NameValuePairListExtensionsTests : UnitTestBase
	{
		private readonly List<NameValuePair> _list = new List<NameValuePair>
			           	{
			           		new NameValuePair("SERVER_NAME", "www.test.nu"),
			           		new NameValuePair("SERVER_PORT", "80")
			           	};

		[Test]
		public void GetValueFromFirstMatch_NameExists_ReturnsValue()
		{
			// act
			var result = _list.GetValueFromFirstMatch("SERVER_NAME");

			// assert
			Assert.That(result, Is.EqualTo("www.test.nu"));
		}

		[Test]
		public void GetValueFromFirstMatch_NameDoesNotExist_ReturnsEmptyString()
		{
			// act
			var result = _list.GetValueFromFirstMatch("SOME_NAME");

			// assert
			Assert.That(result, Is.EqualTo(string.Empty));
		}
	}
}
