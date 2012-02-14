using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToDatabasePresenter
	{
		private static readonly List<NameValuePair> DatabaseTypes = new List<NameValuePair>
		{
		    new NameValuePair(ErrorLogSourcesEnum.SqlServer.ToString(), ErrorLogSourcesEnum.SqlServer.GetDescription()),
		    new NameValuePair(ErrorLogSourcesEnum.SqlCe.ToString(), ErrorLogSourcesEnum.SqlCe.GetDescription())
		};

		public ConnectToDatabasePresenter(IConnectToDatabaseView view)
		{
			View = view;

			Initialize();
		}

		public IConnectToDatabaseView View { get; private set; }
		
		private void Initialize()
		{
			View.LoadDatabaseOptions(DatabaseTypes);
		}
	}
}
