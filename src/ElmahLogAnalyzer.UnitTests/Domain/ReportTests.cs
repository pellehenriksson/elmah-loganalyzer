using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
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
		public void Ctor_QueryIsNull_Throws()
		{
			// act
			var result = Assert.Throws<ArgumentNullException>(() => new Report(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("query"));
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

		[Test]
		public void AddRange_RangeIsNull()
		{
			// arrange
			var report = new Report(CreateReportQuery());

			// act
			var result = Assert.Throws<ArgumentNullException>(() => report.AddRange(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("items"));
		}
	}
}
