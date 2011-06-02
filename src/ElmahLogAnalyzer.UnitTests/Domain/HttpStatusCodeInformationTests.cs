using ElmahLogAnalyzer.Core.Domain;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class HttpStatusCodeInformationTests : UnitTestBase
	{
		[Test]
		public void Ctor_NoArguments_CodeAndDescriptionAreEmpty()
		{
			// act
			var information = new HttpStatusCodeInformation();
			
			// assert
			Assert.That(information.Code, Is.EqualTo(string.Empty));
			Assert.That(information.Description, Is.EqualTo(string.Empty));
		}

		[Test]
		public void Ctor_SetsCodeAndDescription()
		{
			// act
			var information = new HttpStatusCodeInformation("404", "Not found");

			// assert
			Assert.That(information.Code, Is.EqualTo("404"));
			Assert.That(information.Description, Is.EqualTo("Not found"));
		}

		[Test]
		public void DisplayName_IsCodeAndDescription()
		{
			// arrange
			var information = new HttpStatusCodeInformation("404", "Not found");
			
			// assert
			Assert.That(information.DisplayName, Is.EqualTo("404 Not found"));
		}
	}
}
