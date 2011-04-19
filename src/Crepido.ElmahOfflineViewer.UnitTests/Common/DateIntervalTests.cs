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
	}
}
