using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.IntegrationTests
{
	public static class DatabaseHelper
	{
		public static void BuildDatabase(string connectionstring)
		{
			CreateTable(connectionstring);
			LoadTestData(connectionstring);
		}
		
		private static void CreateTable(string connectionstring)
		{
			using (var connection = new SqlConnection(connectionstring))
			{
				connection.Open();
				using (var command = new SqlCommand(GetCreateScript(), connection))
				{
					command.ExecuteNonQuery();
				}
			}
		}

		private static string GetCreateScript()
		{
			var thisAssembly = Assembly.GetExecutingAssembly();
			var filename = string.Format("{0}.{1}", "Crepido.ElmahOfflineViewer.IntegrationTests._DatabaseScripts", "MsSqlServer.txt");
			var resourceStream = thisAssembly.GetManifestResourceStream(filename);

			if (resourceStream == null)
			{
				throw new Exception(string.Format("The file: {0} was not found in assembly: {1}", filename, thisAssembly.FullName));
			}

			string content;

			using (TextReader textReader = new StreamReader(resourceStream, Encoding.UTF8))
			{
				content = textReader.ReadToEnd();
			}

			return content;
		}

		private static void LoadTestData(string connectionstring)
		{
			var logs = DatabaseTestDataHelper.GetLogs();
			foreach (var errorLog in logs)
			{
				using (var connection = new SqlConnection(connectionstring))
				{
					connection.Open();
					using (var command = CreateCommand(errorLog))
					{
						command.Connection = connection;
						command.ExecuteNonQuery();
					}
				}
			}
		}

		private static SqlCommand CreateCommand(ErrorLog log)
		{
			const string sql = @"
				SET IDENTITY_INSERT ELMAH_Error ON;
				INSERT INTO ELMAH_Error ([ErrorId], [Application], [Host], [Type], [Source], [Message], [User], [StatusCode], [TimeUtc], [Sequence], [AllXml]) VALUES (@errorid, @application, @host, @type, @source, @message, @user, @statuscode, @timeutc, @sequence, @allxml);
				SET IDENTITY_INSERT ELMAH_Error OFF;";
			
			var command = new SqlCommand(sql);

			command.Parameters.AddWithValue("@errorid", log.ErrorId);
			command.Parameters.AddWithValue("@application", @"\");
			command.Parameters.AddWithValue("@host", log.Host);
			command.Parameters.AddWithValue("@type", log.Type);
			command.Parameters.AddWithValue("@source", log.Source);
			command.Parameters.AddWithValue("@message", log.Message);
			command.Parameters.AddWithValue("@user", log.User);
			command.Parameters.AddWithValue("@statuscode", "-1");
			command.Parameters.AddWithValue("@timeutc", log.Time);
			command.Parameters.AddWithValue("@sequence", "-1");
			command.Parameters.AddWithValue("@allxml", log.OriginalLog);

			return command;
		}
	}
}
