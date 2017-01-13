using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Views
{
	public partial class SearchView : UserControl, ISearchView
	{
		public SearchView()
		{
			InitializeComponent();

			_filterView.OnFilterApplied += SearchFilterViewOnSearchFilterApplied;
			_resultView.OnErrorLogSelected += SearchResultTreeViewOnErrorLogSelected;
			_detailsView.OnSearchHttpUserAgentInformationClicked += DetailsViewOnSearchHttpUserAgentInformationClicked;
		}
		
		public event EventHandler OnLoaded;

		public event EventHandler<ErrorLogSearchEventArgs> OnFilterApplied;

		public event EventHandler<ErrorLogSelectedEventArgs> OnErrorLogSelected;

		public event EventHandler<SearchHttpUserAgentInformationEventArgs> OnSearchHttpUserAgentInformation;
		
		public void SetDateInterval(DateInterval interval)
		{
			_filterView.SetDateInterval(interval);
		}

		public void LoadApplications(IEnumerable<string> applications)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x._filterView.LoadApplications(applications));
				return;
			}

			_filterView.LoadApplications(applications);
		}

		public void LoadTypes(IEnumerable<string> types)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x._filterView.LoadTypes(types));
				return;
			}

			_filterView.LoadTypes(types);
		}

		public void LoadSources(IEnumerable<string> sources)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x._filterView.LoadSources(sources));
				return;
			}

			_filterView.LoadSources(sources);
		}

		public void LoadUsers(IEnumerable<string> users)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x._filterView.LoadUsers(users));
				return;
			}

			_filterView.LoadUsers(users);
		}

		public void LoadUrls(IEnumerable<string> urls)
		{
			if (InvokeRequired)
			{
				this.InvokeEx(x => x._filterView.LoadUrls(urls));
				return;
			}

			_filterView.LoadUrls(urls);
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
