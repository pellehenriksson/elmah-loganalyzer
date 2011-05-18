using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class CsvParserTests : UnitTestBase
	{
		[Test]
		public void Parse_ShouldParse_ReturnsDetailsUrlAndDateTimeInDictionary()
		{
			// arrange
			var parser = new CsvParser();
			
			// act
			var result = parser.Parse(GetCsvContent());

			// assert
			Assert.That(result.Count, Is.EqualTo(10));
		}
	}
}
