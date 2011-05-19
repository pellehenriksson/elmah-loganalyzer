using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;

namespace Crepido.ElmahOfflineViewer.UI.Views
{
	public partial class SearchView : UserControl, ISearchView
	{
		public SearchView()
		{
			InitializeComponent();

			_FilterView.OnFilterApplied += SearchFilterViewOnSearchFilterApplied;
			_resultView.OnErrorLogSelected += SearchResultTreeViewOnErrorLogSelected;
			_detailsView.OnSearchHttpUserAgentInformationClicked += DetailsViewOnSearchHttpUserAgentInformationClicked;
		}
		
		public event EventHandler OnLoaded;

		public event EventHandler<ErrorLogSearchEventArgs> OnFilterApplied;

		public event EventHandler<ErrorLogSelectedEventArgs> OnErrorLogSelected;

		public event EventHandler<SearchHttpUserAgentInformationEventArgs> OnSearchHttpUserAgentInformation;

		public void SetDateInterval(DateInterval interval)
		{
			_FilterView.SetDateInterval(interval);
		}

		public void LoadTypes(IEnumerable<string> types)
		{
			_FilterView.LoadTypes(types);
		}

		public void LoadSources(IEnumerable<string> sources)
		{
			_FilterView.LoadSources(sources);
		}

		public void LoadUsers(IEnumerable<string> users)
		{
			_FilterView.LoadUsers(users);
		}

		public void LoadUrls(IEnumerable<string> urls)
		{
			_FilterView.LoadUrls(urls);
		}

		public void DisplaySearchResult(IList<ErrorLog> errorLogs)
		{
			_resultView.LoadTree(errorLogs);
		}
		
		public void DisplayErrorDetails(ErrorLog error)
		{
			_detailsView.DisplayError(error);
		}

		public void ClearResult()
		{
			_resultView.ClearView();
		}

		public void ClearErrorDetails()
		{
			_detailsView.ClearView();
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

		private void DetailsViewOnSearchHttpUserAgentInformationClicked(object sender, SearchHttpUserAgentInformationEventArgs e)
		{
			if (OnSearchHttpUserAgentInformation != null)
			{
				OnSearchHttpUserAgentInformation(this, e);
			}
		}
	}
}
