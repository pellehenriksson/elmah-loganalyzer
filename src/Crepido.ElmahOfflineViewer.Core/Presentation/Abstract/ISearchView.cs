using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.Core.Presentation.Abstract
{
	public interface ISearchView
	{
		event EventHandler<ErrorLogSearchEventArgs> OnFilterApplied;

		event EventHandler<ErrorLogSelectedEventArgs> OnErrorLogSelected;

		void SetTimeInterval(DateTime startTime, DateTime endTime);

		void LoadTypes(List<string> types);

		void LoadSources(List<string> sources);

		void LoadUsers(List<string> users);

		void DisplaySearchResult(IList<ErrorLog> errorLogs);
		
		void DisplayErrorDetails(ErrorLog error);

		void ClearResult();

		void ClearErrorDetails();
	}
}
