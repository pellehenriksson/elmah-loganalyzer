using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Integrations;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class SearchPresenter
	{
		private readonly IErrorLogRepository _repository;
		private readonly IHttpUserAgentStringSearchLauncher _httpUserAgentStringSearchLauncher;

		public SearchPresenter(ISearchView view, IErrorLogRepository errorLogRepository, IHttpUserAgentStringSearchLauncher httpUserAgentStringSearchLauncher)
		{
			View = view;
			_repository = errorLogRepository;
			_httpUserAgentStringSearchLauncher = httpUserAgentStringSearchLauncher;

			RegisterEvents();
		}

		public ISearchView View { get; private set; }
		
		private void RegisterEvents()
		{
			View.OnLoaded += ViewOnLoaded;
			View.OnFilterApplied += ViewOnFilterApplied;
			View.OnErrorLogSelected += ViewOnErrorLogSelected;
			View.OnSearchHttpUserAgentInformation += ViewOnSearchHttpUserAgentInformation;
			_repository.OnInitialized += RepositoryOnInitialized;
		}
		
		private void Initialize()
		{
			InitializeDateInterval();
			InitializeFilterValues();
		}

		private void InitializeFilterValues()
		{
			View.LoadTypes(_repository.GetTypes());
			View.LoadSources(_repository.GetSources());
			View.LoadUsers(_repository.GetUsers());
			View.LoadUrls(_repository.GetUrls());
		}

		private void InitializeDateInterval()
		{
			var interval = DateInterval.Create(DateIntervalSpanEnum.Week, DateTime.Today);
			View.SetDateInterval(interval);
		}
		
		private void ViewOnLoaded(object sender, EventArgs e)
		{
			Initialize();
		}

		private void ViewOnErrorLogSelected(object sender, ErrorLogSelectedEventArgs e)
		{
			View.DisplayErrorDetails(e.ErrorLog);
		}

		private void ViewOnFilterApplied(object sender, ErrorLogSearchEventArgs e)
		{
			View.ClearErrorDetails();

			var result = _repository.GetWithFilter(e.Query);

			View.DisplaySearchResult(result);
		}

		private void RepositoryOnInitialized(object sender, RepositoryInitializedEventArgs e)
		{
			View.ClearResult();
			View.ClearErrorDetails();

			InitializeFilterValues();
		}

		private void ViewOnSearchHttpUserAgentInformation(object sender, SearchHttpUserAgentInformationEventArgs e)
		{
			_httpUserAgentStringSearchLauncher.Launch(e.HttpUserAgentString);	
		}
	}
}
