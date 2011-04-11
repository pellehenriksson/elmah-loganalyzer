using System;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class SearchPresenter
	{
		private readonly ISearchView _view;
		private readonly IErrorLogRepository _errorLogsRepository;

		public SearchPresenter(ISearchView view, IErrorLogRepository errorLogRepository)
		{
			_view = view;
			_errorLogsRepository = errorLogRepository;

			RegisterEvents();
		}

		public void Initialize()
		{
			_view.SetTimeInterval(DateTime.Today.AddDays(-7), DateTime.Today);
			_view.LoadTypes(_errorLogsRepository.GetTypes());
			_view.LoadSources(_errorLogsRepository.GetSources());
			_view.LoadUsers(_errorLogsRepository.GetUsers());
		}

		private void RegisterEvents()
		{
			_view.OnFilterApplied += ViewOnFilterApplied;
			_view.OnErrorLogSelected += ViewOnErrorLogSelected;
		}

		private void ViewOnErrorLogSelected(object sender, ErrorLogSelectedEventArgs e)
		{
			_view.DisplayErrorDetails(e.ErrorLog);
		}

		private void ViewOnFilterApplied(object sender, ErrorLogSearchEventArgs e)
		{
			_view.ClearErrorDetails();

			var result = _errorLogsRepository.GetWithFilter(e.Query);

			_view.DisplaySearchResult(result);
		}
	}
}
