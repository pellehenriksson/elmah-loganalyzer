using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Configuration;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToSqlServerPresenter
	{
		private readonly IDatabaseConnectionsHelper _databaseConnectionsHelper;

		public ConnectToSqlServerPresenter(IConnectToSqlServerView view, IDatabaseConnectionsHelper databaseConnectionsHelper)
		{
			View = view;
			_databaseConnectionsHelper = databaseConnectionsHelper;

			RegisterEvents();

			View.LoadConnections(_databaseConnectionsHelper.GetNames(ErrorLogSources.SqlServer.ToString()));
		}

		public IConnectToSqlServerView View { get; private set; }
			
		private void RegisterEvents()
		{
			View.OnConnectionSelected += (sender, args) =>
			{
				var connection = _databaseConnectionsHelper.FindConnection(args.Url);
				View.Server = connection.Server;
				View.Database = connection.Database;
				View.Schema = connection.Schema;

                if (connection.UseIntegratedSecurity)
                {
                    View.UseIntegratedSecurity = true;
                }
                else
                {
                    View.UseIntegratedSecurity = false;
                    View.Username = connection.Username;
                    View.Password = connection.Password;
                }
			};

			View.OnConnectToDatabase += (sender, args) =>
			{
				if (!AllRequiredFieldsHaveValues())
				{
					View.DisplayErrorMessage("Not all required fields have values");
					return;
				}

				View.CloseView();
			};
		}

		private bool AllRequiredFieldsHaveValues()
		{
			var isValid = !string.IsNullOrWhiteSpace(View.Server) && !string.IsNullOrWhiteSpace(View.Database);

			if (!isValid)
			{
				return false;
			}

			if (!View.UseIntegratedSecurity && string.IsNullOrWhiteSpace(View.Username))
			{
				return false;
			}

			return true;
		}
	}
}
