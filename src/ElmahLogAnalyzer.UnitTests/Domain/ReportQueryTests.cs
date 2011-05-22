using System;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
    using System.Globalization;

    [TestFixture]
	public class ReportQueryTests : UnitTestBase
	{
		[Test]
		public void ToString_ReportDescriptionStartAndEndTime()
		{
			// arrange
			var query = new ReportQuery(ReportTypeEnum.Type, new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 8)));

			// act
            var formatInfo = (DateTimeFormatInfo)DateTimeFormatInfo.InvariantInfo.Clone();
            formatInfo.ShortDatePattern = "yyyy-MM-dd";
            var result = query.ToString(formatInfo);

			// assert
			Assert.That(result, Is.EquivalentTo("Number of errors per type from 1975-05-14 to 2011-04-08"));
		}
	}
}
