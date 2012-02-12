using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Constants;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ConnectToDatabasePresenter
	{
		private static readonly List<NameValuePair> DatabaseTypes = new List<NameValuePair>
		{
		    new NameValuePair(Databases.SqlServer, Databases.SqlServer),
		    new NameValuePair(Databases.SqlCe, Databases.SqlCe)
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
