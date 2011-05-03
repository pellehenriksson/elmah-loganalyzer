using System;
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
		public void Ctor_HasClientInformation()
		{
			// arrange
			var error = new ErrorLog();
			
			// assert
			Assert.That(error.ClientInformation, Is.Not.Null);
		}

		[Test]
		public void SetClientInformation_SetsInformation()
		{
			// arrange
			var error = new ErrorLog();
			var info = new ClientInformation();

			// act
			error.SetClientInformation(info);

			// assert
			Assert.That(error.ClientInformation, Is.EqualTo(info));
		}

		[Test]
		public void SetClientInformation_InformationIsNull_Throws()
		{
			// arrange
			var error = new ErrorLog();

			// act
			var result = Assert.Throws<ArgumentNullException>(() => error.SetClientInformation(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("information"));
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
			error.AddServerVariable(HttpServerVariables.LogonUser, @"domain\user");
			
			// assert
			Assert.That(error.User, Is.EqualTo(@"domain\user"));
		}

		[Test]
		public void AddServerVariable_NameIsURL_SetAsUrl()
		{
			// arrange
			var error = new ErrorLog();

			// act
			error.AddServerVariable(HttpServerVariables.Url, @"/some/kind/of/monster");

			// assert
			Assert.That(error.Url, Is.EqualTo(@"/some/kind/of/monster"));
		}

		[Test]
		public void AddServerVariable_NameIsHttpUserAgent_SetAsHttpUserAgent()
		{
			// arrange
			var error = new ErrorLog();

			// act
			error.AddServerVariable(HttpServerVariables.HttpUserAgent, @"/some/kind/of/monster");

			// assert
			Assert.That(error.HttpUserAgent, Is.EqualTo(@"/some/kind/of/monster"));
		}
	}
}
