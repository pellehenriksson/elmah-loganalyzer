using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ServerVariableTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsNameAndValue()
		{
			// act
			var variable = new ErrorLog.ServerVariable("name", "value");

			// assert
			Assert.That(variable.Name, Is.EqualTo("name"));
			Assert.That(variable.Value, Is.EqualTo("value"));
		}
	}
}
