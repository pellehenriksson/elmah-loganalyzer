using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Common
{
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
			var interval1 = new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 20));

			// act
			var result = interval1.Equals(null);

			// assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void Equals_OtherIntervalIsSameInstance_IsTrue()
		{
			// arrange
			var interval1 = new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 20));

			// act
			var result = interval1.Equals(interval1);

			// assert
			Assert.That(result, Is.True);
		}
	}
}
