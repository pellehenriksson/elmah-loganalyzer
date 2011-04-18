using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ReportQueryTests : UnitTestBase
	{
		[Test]
		public void ToString_ReportDescriptionStartAndEndTime()
		{
			// arrange
			var query = new ReportQuery(ReportTypeEnum.Type, new DateTime(1975, 5, 14), new DateTime(2011, 4, 8));

			// act
			var result = query.ToString();

			// assert
			Assert.That(result, Is.EquivalentTo("Number of errors per type from 1975-05-14 to 2011-04-08"));
		}
	}
}
