using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;

namespace Crepido.ElmahOfflineViewer.UI.Views
{
	public partial class SearchView : UserControl, ISearchView
	{
		public SearchView()
		{
			InitializeComponent();

			_searchFilterView.OnFilterApplied += SearchFilterViewOnSearchFilterApplied;
			searchResultTreeView.OnErrorLogSelected += SearchResultTreeViewOnErrorLogSelected;
		}

		public event EventHandler<ErrorLogSearchEventArgs> OnFilterApplied;

		public event EventHandler<ErrorLogSelectedEventArgs> OnErrorLogSelected;

		public void SetTimeInterval(DateTime startTime, DateTime endTime)
		{
			_searchFilterView.SetTimeInterval(startTime, endTime);
		}

		public void LoadTypes(List<string> types)
		{
			_searchFilterView.LoadTypes(types);
		}

		public void LoadSources(List<string> sources)
		{
			_searchFilterView.LoadSources(sources);
		}

		public void LoadUsers(List<string> users)
		{
			_searchFilterView.LoadUsers(users);
		}
		
		public void DisplaySearchResult(IList<ErrorLog> errorLogs)
		{
			searchResultTreeView.LoadTree(errorLogs);
		}
		
		public void DisplayErrorDetails(ErrorLog error)
		{
			_searchDetailsView.DisplayError(error);
		}

		public void ClearErrorDetails()
		{
			_searchDetailsView.Clear();
		}

		private void SearchResultTreeViewOnErrorLogSelected(object sender, ErrorLogSelectedEventArgs e)
		{
			if (OnErrorLogSelected != null)
			{
				OnErrorLogSelected(this, e);
			}
		}

		private void SearchFilterViewOnSearchFilterApplied(object sender, ErrorLogSearchEventArgs e)
		{
			if (OnFilterApplied != null)
			{
				OnFilterApplied(this, e);
			}
		}
	}
}
