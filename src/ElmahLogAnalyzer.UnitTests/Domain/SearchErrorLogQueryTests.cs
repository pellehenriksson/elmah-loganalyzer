using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class SearchErrorLogQueryTests : UnitTestBase
	{
		[Test]
		public void Ctor_HasEmptyTypes()
		{
			// arrange
			var query = new SearchErrorLogQuery();
			
			// assert
			Assert.That(query.Types, Is.Not.Null);
		}

		[Test]
		public void Ctor_HasEmptySources()
		{
			// arrange
			var query = new SearchErrorLogQuery();

			// assert
			Assert.That(query.Sources, Is.Not.Null);
		}

		[Test]
		public void Ctor_HasEmptyUsers()
		{
			// arrange
			var query = new SearchErrorLogQuery();

			// assert
			Assert.That(query.Users, Is.Not.Null);
		}

		[Test]
		public void Ctor_HasEmptyUrls()
		{
			// arrange
			var query = new SearchErrorLogQuery();

			// assert
			Assert.That(query.Urls, Is.Not.Null);
		}
		
		[Test]
		public void CreateWithReportQuerySetsStartAndEndTime()
		{
			// arrange
			var reportQuery = CreateReportQuery();

			// act
			var result = SearchErrorLogQuery.Create(reportQuery);

			// assert
			Assert.That(result.Interval, Is.EqualTo(reportQuery.Interval));
		}
	}
}
