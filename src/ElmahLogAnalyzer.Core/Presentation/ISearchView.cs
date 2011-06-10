using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface ISearchView
	{
		event EventHandler OnLoaded;

		event EventHandler<ErrorLogSearchEventArgs> OnFilterApplied;

		event EventHandler<ErrorLogSelectedEventArgs> OnErrorLogSelected;

		event EventHandler<SearchHttpUserAgentInformationEventArgs> OnSearchHttpUserAgentInformation;
		
		void SetDateInterval(DateInterval interval);

		void LoadTypes(IEnumerable<string> types);

		void LoadSources(IEnumerable<string> sources);

		void LoadUsers(IEnumerable<string> users);

		void LoadUrls(IEnumerable<string> urls);

		void DisplaySearchResult(IList<ErrorLog> errorLogs);
		
		void DisplayErrorDetails(ErrorLog error);

		void ClearResult();

		void ClearErrorDetails();
	}
}
