using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ReportTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsReportQuery()
		{
			// arrange
			var query = CreateReportQuery();
			
			// act
			var report = new Report(query);

			// assert
			Assert.That(report.Query, Is.EqualTo(query));
		}

		[Test]
		public void Ctor_HasEmptyItemsList()
		{
			// arrange
			var report = new Report(CreateReportQuery());
			
			// assert
			Assert.That(report.Items.Count, Is.EqualTo(0));
		}

		[Test]
		public void AddRange_AddsRangeToItems()
		{
			// arrange
			var report = new Report(CreateReportQuery());
			var range = new List<ReportItem> { new ReportItem("key", 10) };

			// act
			report.AddRange(range);

			// assert
			Assert.That(report.Items.Count, Is.EqualTo(1));
		}
	}
}
