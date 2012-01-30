using System;
using System.Data;
using System.Data.SqlServerCe;
using Dapper;

namespace ElmahLogAnalyzer.Core.Domain.Export
{
	public class ErrorLogExporter : IErrorLogExporter
	{
		private readonly IErrorLogRepository _repository;
		private readonly IDatabaseCreator _databaseCreator;
		
		private const string ProgressMessage = "Exporting error log {0} of {1}";

		private bool _cancel;

		public ErrorLogExporter(IErrorLogRepository repository, IDatabaseCreator databaseCreator)
		{
			_repository = repository;
			_databaseCreator = databaseCreator;
			_cancel = false;
		}

		public event EventHandler OnCompleted;

		public event EventHandler<ErrorLogExporterErrorEventArgs> OnError;

		public event EventHandler<ErrorLogExporterProgressEventArgs> OnProgressChanged;

		public void Export(string databaseFilename)
		{
			try
			{
				_databaseCreator.Create(databaseFilename);
				var connectionString = string.Format("Data Source = {0};", databaseFilename);

				using (IDbConnection connection = new SqlCeConnection(connectionString))
				{
					connection.Open();

					var errorlogs = _repository.GetAll();
					var totalNumberOfLogs = errorlogs.Count;
					var counter = 1;

					foreach (var errorlog in errorlogs)
					{
						if (_cancel)
						{
							break;
						}

						PersistErrorLog(connection, errorlog);
						PersistServerVariables(connection, errorlog);
						PersistFormValues(connection, errorlog);
						PersistCookieValues(connection, errorlog);
						PersistQuerystringValues(connection, errorlog);
						PersistClientInformation(connection, errorlog);
						PersistServerInformation(connection, errorlog);

						if (OnProgressChanged != null)
						{
							var progressMessage = string.Format(ProgressMessage, counter, totalNumberOfLogs);
							OnProgressChanged(this, new ErrorLogExporterProgressEventArgs(progressMessage));
						}
						
						counter++;
					}
				}

				if (OnCompleted != null)
				{
					OnCompleted(this, new EventArgs());
				}
			}
			catch (Exception ex)
			{
				if (OnError != null)
				{
					OnError(this, new ErrorLogExporterErrorEventArgs(ex));
				}
				else
				{
					throw;
				}
			}
		}

		public void Cancel()
		{
			_cancel = true;
		}
		
		private static void PersistErrorLog(IDbConnection connection, ErrorLog errorlog)
		{
			const string sql = @"INSERT INTO ErrorLogs (ErrorId, Host, Type, Message, Source, Details, Time, StatusCode, [User], Url) 
						VALUES (@errorId, @host, @type, @message, @source, @details, @time, @statusCode, @user, @url);";
					
			var parameters = new DynamicParameters();
			parameters.Add("@errorId", errorlog.ErrorId.ToString());
			parameters.Add("@host", errorlog.Host);
			parameters.Add("@type", errorlog.Type);
			parameters.Add("@message", errorlog.Message);
			parameters.Add("@source", errorlog.Source);
			parameters.Add("@details", errorlog.Details);
			parameters.Add("@time", errorlog.Time);
			parameters.Add("@statusCode", errorlog.StatusCode);
			parameters.Add("@user", errorlog.User);
			parameters.Add("@url", errorlog.Url);

			connection.Execute(sql, parameters);
		}
		
		private static void PersistServerVariables(IDbConnection connection, ErrorLog errorlog)
		{
			foreach (var variable in errorlog.ServerVariables)
			{
				connection.Execute(
					"INSERT INTO ServerVariables (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", 
					new { variable.Name, variable.Value, errorLogId = errorlog.ErrorId });
			}
		}

		private static void PersistFormValues(IDbConnection connection, ErrorLog errorlog)
		{
			foreach (var formValue in errorlog.FormValues)
			{
				connection.Execute(
					"INSERT INTO FormValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", 
					new { formValue.Name, formValue.Value, errorLogId = errorlog.ErrorId });
			}
		}

		private static void PersistCookieValues(IDbConnection connection, ErrorLog errorlog)
		{
			foreach (var cookie in errorlog.Cookies)
			{
				connection.Execute(
					"INSERT INTO CookieValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", 
					new { cookie.Name, cookie.Value, errorLogId = errorlog.ErrorId });
			}
		}

		private static void PersistQuerystringValues(IDbConnection connection, ErrorLog errorlog)
		{
			foreach (var qstring in errorlog.QuerystringValues)
			{
				connection.Execute(
					"INSERT INTO QuerystringValues (Name, Value, ErrorLogId) VALUES (@name, @value, @errorLogId)", 
					new { qstring.Name, qstring.Value, errorLogId = errorlog.ErrorId });
			}
		}
		
		private static void PersistServerInformation(IDbConnection connection, ErrorLog errorlog)
		{
			var serverInfo = errorlog.ServerInformation;
					
			connection.Execute(
				"INSERT INTO ServerInformation (Host, Name, Port, Software, ErrorLogId) VALUES (@host, @name, @port, @software, @errorLogId)",
				new { serverInfo.Host, serverInfo.Name, serverInfo.Port, serverInfo.Software, errorLogId = errorlog.ErrorId });
		}

		private static void PersistClientInformation(IDbConnection connection, ErrorLog errorlog)
		{
			var clientInfo = errorlog.ClientInformation;

			connection.Execute(
				"INSERT INTO ClientInformation (Browser, OperatingSystem, Platform, Description, ErrorLogId) VALUES (@browser, @operatingSystem, @platform, @description, @errorLogId)",
				new { clientInfo.Browser, clientInfo.OperatingSystem, clientInfo.Platform, clientInfo.Description, errorLogId = errorlog.ErrorId });
		}
	}
}
