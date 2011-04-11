using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ErrorLogTests : UnitTestBase
	{
		[Test]
		public void Ctor_HasEmptyServerVariablesList()
		{
			// act
			var error = new ErrorLog();

			// assert
			Assert.That(error.ServerVariables.Count, Is.EqualTo(0));
		}

		[Test]
		public void AddServerVariable_AddsVariable()
		{
			// arrange
			var error = new ErrorLog();

			// act
			error.AddServerVariable("name", "value");

			// assert
			Assert.That(error.ServerVariables.Count, Is.EqualTo(1));

			var variable = error.ServerVariables[0];
			Assert.That(variable.Name, Is.EqualTo("name"));
			Assert.That(variable.Value, Is.EqualTo("value"));
		}

		[Test]
		public void AddServerVariable_NameIsLogon_User_SetAsUser()
		{
			// arrange
			var error = new ErrorLog();

			// act
			error.AddServerVariable("LOGON_USER", @"domain\user");
			
			// assert
			Assert.That(error.User, Is.EqualTo(@"domain\user"));
		}

		[Test]
		public void AddServerVariable_NameIsURL_SetAsUrl()
		{
			// arrange
			var error = new ErrorLog();

			// act
			error.AddServerVariable("URL", @"/some/kind/of/monster");

			// assert
			Assert.That(error.Url, Is.EqualTo(@"/some/kind/of/monster"));
		}
	}
}
