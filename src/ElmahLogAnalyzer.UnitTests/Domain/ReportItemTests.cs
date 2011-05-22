using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class ReportItemTests : UnitTestBase
	{
		[Test]
		public void Ctor_AddsKeyAndCount()
		{
			// act
			var item = new ReportItem("key", 10);

			// assert
			Assert.That(item.Key, Is.EqualTo("key"));
			Assert.That(item.Count, Is.EqualTo(10));
		}
	}
}
