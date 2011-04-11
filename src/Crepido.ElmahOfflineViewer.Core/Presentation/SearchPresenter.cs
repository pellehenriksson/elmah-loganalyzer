using System;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class SearchPresenter
	{
		private readonly ISearchView _view;
		private readonly IErrorLogRepository _repository;

		public SearchPresenter(ISearchView view, IErrorLogRepository errorLogRepository)
		{
			_view = view;
			_repository = errorLogRepository;

			RegisterEvents();
		}

		public void Initialize()
		{
			_view.SetTimeInterval(DateTime.Today.AddDays(-7), DateTime.Today);
			_view.LoadTypes(_repository.GetTypes());
			_view.LoadSources(_repository.GetSources());
			_view.LoadUsers(_repository.GetUsers());
		}

		private void RegisterEvents()
		{
			_view.OnFilterApplied += ViewOnFilterApplied;
			_view.OnErrorLogSelected += ViewOnErrorLogSelected;
			_repository.OnInitialized += RepositoryOnInitialized;
		}

		private void RepositoryOnInitialized(object sender, Domain.RepositoryInitializedEventArgs e)
		{
			_view.ClearResult();
			_view.ClearErrorDetails();
		}

		private void ViewOnErrorLogSelected(object sender, ErrorLogSelectedEventArgs e)
		{
			_view.DisplayErrorDetails(e.ErrorLog);
		}

		private void ViewOnFilterApplied(object sender, ErrorLogSearchEventArgs e)
		{
			_view.ClearErrorDetails();

			var result = _repository.GetWithFilter(e.Query);

			_view.DisplaySearchResult(result);
		}
	}
}
