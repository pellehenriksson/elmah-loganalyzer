using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ErrorLogFileParserTests : UnitTestBase
	{
		[Test]
		public void Parse_ReturnsErrorLogWithFileContent()
		{
			// arrange
			var parser = new ErrorLogFileParser();

			// act
			var result = parser.Parse(GetValidFileContent());

			// assert
			Assert.That(result.ErrorId, Is.EqualTo("dce7f8f3-ac74-4ad9-9435-a344be794c7e"));
			Assert.That(result.Host, Is.EqualTo("ALVA"));
			Assert.That(result.User, Is.EqualTo(@"alva\per"));
			Assert.That(result.Url, Is.EqualTo("/"));
			Assert.That(result.Type, Is.EqualTo("System.Data.SqlClient.SqlException"));
			Assert.That(result.Message, Is.EqualTo("A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 26 - Error Locating Server/Instance Specified)"));
			Assert.That(result.Source, Is.EqualTo(".Net SqlClient Data Provider"));
			Assert.That(result.ServerVariables.Count > 0);
		}

		[Test]
		public void Parse_FileIsNotInCorrectFormat_ReturnsNull()
		{
			// arrange
			var parser = new ErrorLogFileParser();

			// act
			var result = parser.Parse(GetInvalidFileContent());
			
			// assert
			Assert.That(result, Is.Null);
		}

		private static string GetValidFileContent()
		{
			return @"<error errorId=""dce7f8f3-ac74-4ad9-9435-a344be794c7e"" host=""ALVA"" type=""System.Data.SqlClient.SqlException"" message=""A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 26 - Error Locating Server/Instance Specified)"" source="".Net SqlClient Data Provider"" detail=""System.TypeInitializationException: The type initializer for 'Nested' threw an exception. ---&gt; System.Data.SqlClient.SqlException: A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 26 - Error Locating Server/Instance Specified)&#xD;&#xA;   at System.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection)&#xD;&#xA;   at System.Data.SqlClient.TdsParser.ThrowExceptionAndWarning()&#xD;&#xA;   at System.Data.SqlClient.TdsParser.Connect(ServerInfo serverInfo, SqlInternalConnectionTds connHandler, Boolean ignoreSniOpenTimeout, Int64 timerExpire, Boolean encrypt, Boolean trustServerCert, Boolean integratedSecurity)&#xD;&#xA;   at System.Data.SqlClient.SqlInternalConnectionTds.AttemptOneLogin(ServerInfo serverInfo, String newPassword, Boolean ignoreSniOpenTimeout, TimeoutTimer timeout, SqlConnection owningObject)&#xD;&#xA;   at System.Data.SqlClient.SqlInternalConnectionTds.LoginNoFailover(ServerInfo serverInfo, String newPassword, Boolean redirectedUserInstance, SqlConnection owningObject, SqlConnectionString connectionOptions, TimeoutTimer timeout)&#xD;&#xA;   at System.Data.SqlClient.SqlInternalConnectionTds.OpenLoginEnlist(SqlConnection owningObject, TimeoutTimer timeout, SqlConnectionString connectionOptions, String newPassword, Boolean redirectedUserInstance)&#xD;&#xA;   at System.Data.SqlClient.SqlInternalConnectionTds..ctor(DbConnectionPoolIdentity identity, SqlConnectionString connectionOptions, Object providerInfo, String newPassword, SqlConnection owningObject, Boolean redirectedUserInstance)&#xD;&#xA;   at System.Data.SqlClient.SqlConnectionFactory.CreateConnection(DbConnectionOptions options, Object poolGroupProviderInfo, DbConnectionPool pool, DbConnection owningConnection)&#xD;&#xA;   at System.Data.ProviderBase.DbConnectionFactory.CreatePooledConnection(DbConnection owningConnection, DbConnectionPool pool, DbConnectionOptions options)&#xD;&#xA;   at System.Data.ProviderBase.DbConnectionPool.CreateObject(DbConnection owningObject)&#xD;&#xA;   at System.Data.ProviderBase.DbConnectionPool.UserCreateRequest(DbConnection owningObject)&#xD;&#xA;   at System.Data.ProviderBase.DbConnectionPool.GetConnection(DbConnection owningObject)&#xD;&#xA;   at System.Data.ProviderBase.DbConnectionFactory.GetConnection(DbConnection owningConnection)&#xD;&#xA;   at System.Data.ProviderBase.DbConnectionClosed.OpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory)&#xD;&#xA;   at System.Data.SqlClient.SqlConnection.Open()&#xD;&#xA;   at NHibernate.Connection.DriverConnectionProvider.GetConnection()&#xD;&#xA;   at NHibernate.Tool.hbm2ddl.SuppliedConnectionProviderConnectionHelper.Prepare()&#xD;&#xA;   at NHibernate.Tool.hbm2ddl.SchemaMetadataUpdater.GetReservedWords(Dialect dialect, IConnectionHelper connectionHelper)&#xD;&#xA;   at NHibernate.Tool.hbm2ddl.SchemaMetadataUpdater.Update(ISessionFactory sessionFactory)&#xD;&#xA;   at NHibernate.Impl.SessionFactoryImpl..ctor(Configuration cfg, IMapping mapping, Settings settings, EventListeners listeners)&#xD;&#xA;   at NHibernate.Cfg.Configuration.BuildSessionFactory()&#xD;&#xA;   at Sodra.PP.Infrastructure.NHibernate.NHibernateSessionManager.InitSessionFactory() in C:\Projects\Crepido\produktionsportalen_trunk\src\Sodra.PP\Sodra.PP.Infrastructure.NHibernate\NHibernateSessionManager.cs:line 57&#xD;&#xA;   at Sodra.PP.Infrastructure.NHibernate.NHibernateSessionManager..ctor() in C:\Projects\Crepido\produktionsportalen_trunk\src\Sodra.PP\Sodra.PP.Infrastructure.NHibernate\NHibernateSessionManager.cs:line 36&#xD;&#xA;   at Sodra.PP.Infrastructure.NHibernate.NHibernateSessionManager.Nested..cctor() in C:\Projects\Crepido\produktionsportalen_trunk\src\Sodra.PP\Sodra.PP.Infrastructure.NHibernate\NHibernateSessionManager.cs:line 44&#xD;&#xA;   --- End of inner exception stack trace ---&#xD;&#xA;   at Sodra.PP.Infrastructure.NHibernate.NHibernateSessionManager.get_Instance() in C:\Projects\Crepido\produktionsportalen_trunk\src\Sodra.PP\Sodra.PP.Infrastructure.NHibernate\NHibernateSessionManager.cs:line 27"" time=""2011-03-25T07:33:03.1788990Z"">
  <serverVariables>
    <item name=""ALL_HTTP"">
      <value string=""HTTP_CONNECTION:Keep-Alive&#xD;&#xA;HTTP_ACCEPT:*/*&#xD;&#xA;HTTP_ACCEPT_ENCODING:gzip, deflate&#xD;&#xA;HTTP_ACCEPT_LANGUAGE:sv-SE&#xD;&#xA;HTTP_HOST:localhost:53197&#xD;&#xA;HTTP_USER_AGENT:Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)&#xD;&#xA;"" />
    </item>
    <item name=""ALL_RAW"">
      <value string=""Connection: Keep-Alive&#xD;&#xA;Accept: */*&#xD;&#xA;Accept-Encoding: gzip, deflate&#xD;&#xA;Accept-Language: sv-SE&#xD;&#xA;Host: localhost:53197&#xD;&#xA;User-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)&#xD;&#xA;"" />
    </item>
    <item name=""APPL_MD_PATH"">
      <value string="""" />
    </item>
    <item name=""APPL_PHYSICAL_PATH"">
      <value string=""C:\Projects\Crepido\produktionsportalen_trunk\src\Sodra.PP\Sodra.PP.Web\"" />
    </item>
    <item name=""AUTH_TYPE"">
      <value string="""" />
    </item>
    <item name=""AUTH_USER"">
      <value string="""" />
    </item>
    <item name=""AUTH_PASSWORD"">
      <value string="""" />
    </item>
    <item name=""LOGON_USER"">
      <value string=""alva\per"" />
    </item>
    <item name=""REMOTE_USER"">
      <value string="""" />
    </item>
    <item name=""CERT_COOKIE"">
      <value string="""" />
    </item>
    <item name=""CERT_FLAGS"">
      <value string="""" />
    </item>
    <item name=""CERT_ISSUER"">
      <value string="""" />
    </item>
    <item name=""CERT_KEYSIZE"">
      <value string="""" />
    </item>
    <item name=""CERT_SECRETKEYSIZE"">
      <value string="""" />
    </item>
    <item name=""CERT_SERIALNUMBER"">
      <value string="""" />
    </item>
    <item name=""CERT_SERVER_ISSUER"">
      <value string="""" />
    </item>
    <item name=""CERT_SERVER_SUBJECT"">
      <value string="""" />
    </item>
    <item name=""CERT_SUBJECT"">
      <value string="""" />
    </item>
    <item name=""CONTENT_LENGTH"">
      <value string=""0"" />
    </item>
    <item name=""CONTENT_TYPE"">
      <value string="""" />
    </item>
    <item name=""GATEWAY_INTERFACE"">
      <value string="""" />
    </item>
    <item name=""HTTPS"">
      <value string="""" />
    </item>
    <item name=""HTTPS_KEYSIZE"">
      <value string="""" />
    </item>
    <item name=""HTTPS_SECRETKEYSIZE"">
      <value string="""" />
    </item>
    <item name=""HTTPS_SERVER_ISSUER"">
      <value string="""" />
    </item>
    <item name=""HTTPS_SERVER_SUBJECT"">
      <value string="""" />
    </item>
    <item name=""INSTANCE_ID"">
      <value string="""" />
    </item>
    <item name=""INSTANCE_META_PATH"">
      <value string="""" />
    </item>
    <item name=""LOCAL_ADDR"">
      <value string=""::1"" />
    </item>
    <item name=""PATH_INFO"">
      <value string=""/"" />
    </item>
    <item name=""PATH_TRANSLATED"">
      <value string=""C:\Projects\Crepido\produktionsportalen_trunk\src\Sodra.PP\Sodra.PP.Web"" />
    </item>
    <item name=""QUERY_STRING"">
      <value string="""" />
    </item>
    <item name=""REMOTE_ADDR"">
      <value string=""::1"" />
    </item>
    <item name=""REMOTE_HOST"">
      <value string=""::1"" />
    </item>
    <item name=""REMOTE_PORT"">
      <value string="""" />
    </item>
    <item name=""REQUEST_METHOD"">
      <value string=""GET"" />
    </item>
    <item name=""SCRIPT_NAME"">
      <value string=""/"" />
    </item>
    <item name=""SERVER_NAME"">
      <value string=""localhost"" />
    </item>
    <item name=""SERVER_PORT"">
      <value string=""53197"" />
    </item>
    <item name=""SERVER_PORT_SECURE"">
      <value string=""0"" />
    </item>
    <item name=""SERVER_PROTOCOL"">
      <value string=""HTTP/1.1"" />
    </item>
    <item name=""SERVER_SOFTWARE"">
      <value string="""" />
    </item>
    <item name=""URL"">
      <value string=""/"" />
    </item>
    <item name=""HTTP_CONNECTION"">
      <value string=""Keep-Alive"" />
    </item>
    <item name=""HTTP_ACCEPT"">
      <value string=""*/*"" />
    </item>
    <item name=""HTTP_ACCEPT_ENCODING"">
      <value string=""gzip, deflate"" />
    </item>
    <item name=""HTTP_ACCEPT_LANGUAGE"">
      <value string=""sv-SE"" />
    </item>
    <item name=""HTTP_HOST"">
      <value string=""localhost:53197"" />
    </item>
    <item name=""HTTP_USER_AGENT"">
      <value string=""Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)"" />
    </item>
  </serverVariables>
</error>";
		}

		private static string GetInvalidFileContent()
		{
			return "<?xml version=\"1.0\" encoding=\"utf-8\" ?><test><fail></fail></test>";
		}
	}
}
