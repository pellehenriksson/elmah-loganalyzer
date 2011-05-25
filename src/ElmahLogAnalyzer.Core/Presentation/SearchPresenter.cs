using System;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class SearchPresenter
	{
		private readonly IErrorLogRepository _repository;
		private readonly IHttpUserAgentSearchLauncherFactory _httpUserAgentSearchLauncherFactory;

		public SearchPresenter(ISearchView view, IErrorLogRepository errorLogRepository, IHttpUserAgentSearchLauncherFactory httpUserAgentSearchLauncherFactory)
		{
			View = view;
			_repository = errorLogRepository;
			_httpUserAgentSearchLauncherFactory = httpUserAgentSearchLauncherFactory;

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
			var searchLauncher = _httpUserAgentSearchLauncherFactory.Create(e.SearchLauncher);
			searchLauncher.Launch(e.HttpUserAgentString);	
		}
	}
}
