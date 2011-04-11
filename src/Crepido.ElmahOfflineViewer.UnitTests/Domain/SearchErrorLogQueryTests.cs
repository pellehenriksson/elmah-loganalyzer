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
			Assert.That(result.StartTime, Is.EqualTo(reportQuery.StartTime));
			Assert.That(result.EndTime, Is.EqualTo(reportQuery.EndTime));
		}
	}
}
