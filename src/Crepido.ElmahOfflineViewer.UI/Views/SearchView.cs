using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Common;
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

			searchFilterView.OnFilterApplied += SearchFilterViewOnSearchFilterApplied;
			searchResultTreeView.OnErrorLogSelected += SearchResultTreeViewOnErrorLogSelected;
		}

		public event EventHandler OnLoaded;

		public event EventHandler<ErrorLogSearchEventArgs> OnFilterApplied;

		public event EventHandler<ErrorLogSelectedEventArgs> OnErrorLogSelected;

		public void SetTimeInterval(DateInterval interval)
		{
			searchFilterView.SetTimeInterval(interval);
		}

		public void LoadTypes(List<string> types)
		{
			searchFilterView.LoadTypes(types);
		}

		public void LoadSources(List<string> sources)
		{
			searchFilterView.LoadSources(sources);
		}

		public void LoadUsers(List<string> users)
		{
			searchFilterView.LoadUsers(users);
		}
		
		public void DisplaySearchResult(IList<ErrorLog> errorLogs)
		{
			searchResultTreeView.LoadTree(errorLogs);
		}
		
		public void DisplayErrorDetails(ErrorLog error)
		{
			searchDetailsView.DisplayError(error);
		}

		public void ClearResult()
		{
			searchResultTreeView.ClearView();
		}

		public void ClearErrorDetails()
		{
			searchDetailsView.ClearView();
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

		private void SearchViewLoad(object sender, EventArgs e)
		{
			if (OnLoaded != null)
			{
				OnLoaded(this, new EventArgs());
			}
		}
	}
}
