using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class SearchPresenter
	{
		private readonly IErrorLogRepository _repository;

		public SearchPresenter(ISearchView view, IErrorLogRepository errorLogRepository)
		{
			View = view;
			_repository = errorLogRepository;

			RegisterEvents();
		}

		public ISearchView View { get; private set; }
		
		private void RegisterEvents()
		{
			View.OnLoaded += ViewOnLoaded;
			View.OnFilterApplied += ViewOnFilterApplied;
			View.OnErrorLogSelected += ViewOnErrorLogSelected;
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
			View.SetDateInterval(new DateInterval(DateTime.Today.AddDays(-7), DateTime.Today));
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

		private void RepositoryOnInitialized(object sender, Domain.RepositoryInitializedEventArgs e)
		{
			View.ClearResult();
			View.ClearErrorDetails();

			InitializeFilterValues();
		}
	}
}
