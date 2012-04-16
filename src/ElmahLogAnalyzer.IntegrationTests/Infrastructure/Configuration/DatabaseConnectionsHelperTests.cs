using ElmahLogAnalyzer.Core.Infrastructure.Configuration;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Infrastructure.Configuration
{
	[TestFixture]
	public class DatabaseConnectionsHelperTests
	{
		[Test]
		public void GetSettings_ReadsConfiguration()
		{
			// arrange
			var helper = new DatabaseConnectionsHelper();

			// act
			var result = helper.GetConnections();

			// assert
			Assert.That(result.Count, Is.EqualTo(3));
		}

		[Test]
		public void GetNamed_ReturnsAllNamesForGivenType()
		{
			// arrange
			var helper = new DatabaseConnectionsHelper();

			// act
			var result = helper.GetNames("SqlServer");

			// assert
			Assert.That(result.Count, Is.EqualTo(2));
		}

		[Test]
		public void GetNamed_NotCaseSensitive_ReturnsAllNamesForGivenType()
		{
			// arrange
			var helper = new DatabaseConnectionsHelper();

			// act
			var result = helper.GetNames("sqlserver");

			// assert
			Assert.That(result.Count, Is.EqualTo(2));
		}

		[Test]
		public void GetNamed_ReturnsEmptyListWhenConnectionsForTypeFound()
		{
			// arrange
			var helper = new DatabaseConnectionsHelper();

			// act
			var result = helper.GetNames("xxx");

			// assert
			Assert.That(result.Count, Is.EqualTo(0));
		}
		
		[Test]
		public void GetSettings_SettingsHaveCorrectValues()
		{
			// arrange
			var helper = new DatabaseConnectionsHelper();

			// act
			var result = helper.GetConnections();

			// assert
			var setting = result[0];

			Assert.That(setting.Type, Is.EqualTo("SqlServer"));
			Assert.That(setting.Name, Is.EqualTo("Development"));
			Assert.That(setting.Server, Is.EqualTo(@".\sqlexpress"));
			Assert.That(setting.Database, Is.EqualTo("dev_db"));
			Assert.That(setting.Username, Is.EqualTo("user"));
			Assert.That(setting.Password, Is.EqualTo("password"));

			setting = result[1];

			Assert.That(setting.Type, Is.EqualTo("SqlServer"));
			Assert.That(setting.Name, Is.EqualTo("Production"));
			Assert.That(setting.Server, Is.EqualTo("SomeServer"));
			Assert.That(setting.Database, Is.EqualTo("prod_db"));
			Assert.That(setting.Username, Is.EqualTo("user"));
			Assert.That(setting.Password, Is.EqualTo("password"));

			setting = result[2];

			Assert.That(setting.Type, Is.EqualTo("SqlServerCompact"));
			Assert.That(setting.Name, Is.EqualTo("SomeCompactDb"));
			Assert.That(setting.File, Is.EqualTo(@"c:\somefile.sdf"));
		}

		[Test]
		public void FindConfiguration_UrlFound_ReturnsConfiguration()
		{
			// arrange
			var helper = new DatabaseConnectionsHelper();

			// act
			var result = helper.FindConnection("Development");

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.Name, Is.EqualTo("Development"));
		}

		[Test]
		public void FindConfiguration_UrlNotFound_ReturnsNull()
		{
			// arrange
			var helper = new DatabaseConnectionsHelper();

			// act
			var result = helper.FindConnection(string.Empty);

			// assert
			Assert.That(result, Is.Null);
		}
	}
}
