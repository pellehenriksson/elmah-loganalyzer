using System;
using ElmahLogAnalyzer.Core.Common;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
	[TestFixture]
	public class DateTimeExtensionsTests : UnitTestBase
	{
		[Test]
		public void IsBetween_BeforeStartDate_IsFalse()
		{
			// arrange
			var date = new DateTime(1975, 5, 14);

			var startDate = date.AddDays(1);
			var endDate = new DateTime(1977, 10, 16);

			// act
			var result = date.IsBetween(startDate, endDate);

			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void IsBetween_AfterEndDate_IsFalse()
		{
			// arrange
			var date = new DateTime(1977, 10, 17);

			var startDate = date;
			var endDate = new DateTime(1977, 10, 16);

			// act
			var result = date.IsBetween(startDate, endDate);

			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void IsBetween_IsAfterStartDateAndBeforeEndDate_IsTrue()
		{
			// arrange
			var date = new DateTime(1975, 5, 14);

			var startDate = date;
			var endDate = new DateTime(1977, 10, 16);
			
			// act
			var result = date.IsBetween(startDate, endDate);

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void IsBetween_WithDateInterval_IsBewteen_IsTrue()
		{
			// arrange
			var interval = new DateInterval(new DateTime(2001, 1, 1), new DateTime(2001, 12, 31));
			var date = new DateTime(2001, 5, 14);

			// act
			var result = date.IsBetween(interval);

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void IsBetween_WithDateInterval_IsBefore_IsFalse()
		{
			// arrange
			var interval = new DateInterval(new DateTime(2001, 1, 1), new DateTime(2001, 12, 31));
			var date = new DateTime(1999, 5, 14);

			// act
			var result = date.IsBetween(interval);

			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void IsBewteen_DateIntervalIsNull_Throws()
		{
			// arrange
			var date = new DateTime(1999, 5, 14);

			// act
			var result = Assert.Throws<ArgumentNullException>(() => date.IsBetween(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("interval"));
		}

		[Test]
		public void ToTruncatedString_RemovesAllSpecialCharachters()
		{
			// arrange
			var date = new DateTime(2011, 6, 30, 16, 19, 20);

			// act
			var result = date.ToTruncatedString();

			// assert
			Assert.That(result, Is.EqualTo("20110630_1619"));
		}
	}
}
