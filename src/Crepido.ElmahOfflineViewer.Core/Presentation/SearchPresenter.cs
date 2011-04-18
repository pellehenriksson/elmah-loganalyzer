using System;
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

		public void Initialize()
		{
			View.SetTimeInterval(DateTime.Today.AddDays(-7), DateTime.Today);
			View.LoadTypes(_repository.GetTypes());
			View.LoadSources(_repository.GetSources());
			View.LoadUsers(_repository.GetUsers());
		}

		private void RegisterEvents()
		{
			View.OnFilterApplied += ViewOnFilterApplied;
			View.OnErrorLogSelected += ViewOnErrorLogSelected;
			_repository.OnInitialized += RepositoryOnInitialized;
		}

		private void RepositoryOnInitialized(object sender, Domain.RepositoryInitializedEventArgs e)
		{
			View.ClearResult();
			View.ClearErrorDetails();
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
	}
}
