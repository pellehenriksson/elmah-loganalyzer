using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class HttpStatusCodeInformationLookUpTests : UnitTestBase
	{
		[Test]
		public void GetInformation_CodeFound_ReturnsInformation()
		{
			// act
			var result = HttpStatusCodeInformationLookUp.GetInformation("404.5");

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.Code, Is.EqualTo("404.5"));
		}

		[Test]
		public void GetInformation_CodeNotFound_ReturnsEmpty()
		{
			// act
			var result = HttpStatusCodeInformationLookUp.GetInformation("000");

			// assert
			Assert.That(result.Code, Is.EqualTo(string.Empty));
			Assert.That(result.Description, Is.EqualTo(string.Empty));
		}

		[Test]
		public void GetInformation_CodeIsNull_ReturnsEmpty()
		{
			// act
			var result = HttpStatusCodeInformationLookUp.GetInformation(null);

			// assert
			Assert.That(result.Code, Is.EqualTo(string.Empty));
			Assert.That(result.Description, Is.EqualTo(string.Empty));
		}
	}
}
