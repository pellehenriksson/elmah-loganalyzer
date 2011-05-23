using System;
using ElmahLogAnalyzer.Core.Common;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
    using System.Globalization;

    [TestFixture]
	public class DateIntervalTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetStartAndEndDate()
		{
			// arrange
			var startDate = DateTime.Today;
			var endDate = DateTime.Today.AddDays(1);

			// act
			var interval = new DateInterval(startDate, endDate);

			// assert
			Assert.That(interval.StartDate, Is.EqualTo(startDate));
			Assert.That(interval.EndDate, Is.EqualTo(endDate));
		}

		[Test]
		public void Equals_SameStartAndEndDate_IsTrue()
		{
			// arrange
			var interval1 = new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 20));
			var interval2 = new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 20));
			
			// act
			var result = interval1.Equals(interval2);

			// assert
			Assert.That(result, Is.True);
		}
		
		[Test]
		public void Equals_DifferentStartAndEndDate_IsFalse()
		{
			// arrange
			var interval1 = new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 20));
			var interval2 = new DateInterval(new DateTime(2006, 8, 19), new DateTime(2011, 4, 20));

			// act
			var result = interval1.Equals(interval2);

			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void Equals_OtherInstanceIsNull_IsFalse()
		{
			// arrange
			var interval = new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 20));

			// act
			var result = interval.Equals(null);

			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void Equals_OtherIntervalIsSameInstance_IsTrue()
		{
			// arrange
			var interval = new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 20));

			// act
			var result = interval.Equals(interval);

			// assert
			Assert.That(result, Is.True);
		}

		[Test]
		public void ToString_ReturnsShortDateFormatOfStartAndEndDate()
		{
			// arrange
			var interval = new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 20));

			// act
            var formatInfo = (DateTimeFormatInfo)DateTimeFormatInfo.InvariantInfo.Clone();
            formatInfo.ShortDatePattern = "yyyy-MM-dd";
            var result = interval.ToString(formatInfo);
			
			// assert
			Assert.That(result, Is.EqualTo("1975-05-14 2011-04-20"));
		}

		[Test]
		public void Create_Week_StartDateIsSevendDaysBackEndDateIsCurrentDate()
		{
			// arrange
			var today = new DateTime(2011, 5, 17);

			// act
			var result = DateInterval.Create(DateIntervalSpanEnum.Week, today);

			// assert
			Assert.That(result.StartDate, Is.EqualTo(new DateTime(2011, 5, 10)));
			Assert.That(result.EndDate, Is.EqualTo(today));
		}

		[Test]
		public void Create_Month_StartDateIsThirthyDaysBackEndDateIsCurrentDate()
		{
			// arrange
			var today = new DateTime(2011, 5, 17);

			// act
			var result = DateInterval.Create(DateIntervalSpanEnum.Month, today);

			// assert
			Assert.That(result.StartDate, Is.EqualTo(new DateTime(2011, 4, 17)));
			Assert.That(result.EndDate, Is.EqualTo(today));
		}
	}
}
