using ElmahLogAnalyzer.Core.Presentation;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ConnectionSelectedEventArgsTests
	{
		[Test]
		public void Ctor_SetsUrl()
		{
			// act
			var args = new ConnectionSelectedEventArgs("http://test.com");

			// assert
			Assert.That(args.Url, Is.EqualTo("http://test.com"));
		}
	}
}
