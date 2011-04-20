using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class SearchErrorLogQueryTests : UnitTestBase
	{
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
