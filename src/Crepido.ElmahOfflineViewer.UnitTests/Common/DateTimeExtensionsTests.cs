using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Common
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
	}
}
