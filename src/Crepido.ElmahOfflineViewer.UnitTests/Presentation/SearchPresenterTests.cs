using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;
using Moq;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Presentation
{
	[TestFixture]
	public class SearchPresenterTests : UnitTestBase
	{
		private Mock<ISearchView> _view;
		private Mock<IErrorLogRepository> _repository;

		[SetUp]
		public void Setup()
		{
			_view = new Mock<ISearchView>();
			_repository = new Mock<IErrorLogRepository>();
		}

		[Test]
		public void Initialize_SetsDefaultTimeInterval()
		{
			// arrange
			var presenter = new SearchPresenter(_view.Object, _repository.Object);

			// act
			presenter.Initialize();

			// assert
			_view.Verify(x => x.SetTimeInterval(DateTime.Today.AddDays(-7), DateTime.Today), Times.Once());
		}

		[Test]
		public void Initialize_ShouldLoadTypesInView()
		{
			// arrange
			var presenter = new SearchPresenter(_view.Object, _repository.Object);

			var types = new List<string>();
			_repository.Setup(x => x.GetTypes()).Returns(types);

			// act
			presenter.Initialize();

			// assert
			_view.Verify(x => x.LoadTypes(types), Times.Once());
		}

		[Test]
		public void Initialize_ShouldLoadSourcesInView()
		{
			// arrange
			var presenter = new SearchPresenter(_view.Object, _repository.Object);

			var sources = new List<string>();
			_repository.Setup(x => x.GetSources()).Returns(sources);

			// act
			presenter.Initialize();

			// assert
			_view.Verify(x => x.LoadSources(sources), Times.Once());
		}

		[Test]
		public void Initialize_ShouldLoadUsersInView()
		{
			// arrange
			var presenter = new SearchPresenter(_view.Object, _repository.Object);

			var users = new List<string>();
			_repository.Setup(x => x.GetUsers()).Returns(users);

			// act
			presenter.Initialize();

			// assert
			_view.Verify(x => x.LoadUsers(users), Times.Once());
		}
		
		[Test]
		public void OnFilterApplied_ShouldClearErrorDetails()
		{
			// arrange
			var presenter = new SearchPresenter(_view.Object, _repository.Object);
			var filter = new SearchErrorLogQuery();
			var args = new ErrorLogSearchEventArgs(filter);
			var searchResult = new List<ErrorLog>();

			_repository.Setup(x => x.GetWithFilter(filter)).Returns(searchResult);

			// act
			_view.Raise(x => x.OnFilterApplied += null, args);

			// assert
			_view.Verify(x => x.ClearErrorDetails(), Times.Once());
		}

		[Test]
		public void OnFilterApplied_ShouldDisplaySearchResult()
		{
			// arrange
			var presenter = new SearchPresenter(_view.Object, _repository.Object);
			var filter = new SearchErrorLogQuery();
			var args = new ErrorLogSearchEventArgs(filter);
			var searchResult = new List<ErrorLog>();

			_repository.Setup(x => x.GetWithFilter(filter)).Returns(searchResult);
			
			// act
			_view.Raise(x => x.OnFilterApplied += null, args);

			// assert
			_view.Verify(x => x.DisplaySearchResult(searchResult), Times.Once());
		}
		
		[Test]
		public void OnErrorSelected_ShouldDisplayErrorDetails()
		{
			// arrange
			var presenter = new SearchPresenter(_view.Object, _repository.Object);
			var error = new ErrorLog();

			// act
			_view.Raise(x => x.OnErrorLogSelected += null, new ErrorLogSelectedEventArgs(error));

			// assert
			_view.Verify(x => x.DisplayErrorDetails(error), Times.Once());
		}

		[Test]
		public void OnInitialized_ShouldClearView()
		{
			// arrange
			var presenter = new SearchPresenter(_view.Object, _repository.Object);

			// act
			_repository.Raise(x => x.OnInitialized += null, new RepositoryInitializedEventArgs(string.Empty, 0));

			// assert
			_view.Verify(x => x.ClearResult(), Times.Once());
			_view.Verify(x => x.ClearErrorDetails(), Times.Once());
		}
	}
}
