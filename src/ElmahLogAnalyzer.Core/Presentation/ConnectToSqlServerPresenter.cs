namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToSqlServerPresenter
	{
		public ConnectToSqlServerPresenter(IConnectToSqlServerView view)
		{
			View = view;
			RegisterEvents();
		}

		public IConnectToSqlServerView View { get; private set; }
			
		private void RegisterEvents()
		{
			View.OnConnectToDatabase += (sender, args) =>
			{
				if (!AllRequiredFieldsHaveValues())
				{
					View.DisplayErrorMessage("Not all required fields have values");
					return;
				}

				View.ClearErrorMessage();
				//// test the connection
				//// verify result
				//// if ok => procees else display error message
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
