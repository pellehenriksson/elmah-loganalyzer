using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Integrations;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Presentation
{
	[TestFixture]
	public class SearchPresenterTests : UnitTestBase
	{
		private Mock<ISearchView> _view;
		private Mock<IErrorLogRepository> _repository;
		private Mock<IHttpUserAgentStringSearchLauncher> _searchLauncher;

		[SetUp]
		public void Setup()
		{
			_view = new Mock<ISearchView>();
			_repository = new Mock<IErrorLogRepository>();
			_searchLauncher = new Mock<IHttpUserAgentStringSearchLauncher>();
		}
		
		[Test]
		public void Ctor_SetsView()
		{
			// act
			var presenter = BuildPresenter();

			// assert
			Assert.That(presenter.View, Is.EqualTo(_view.Object));
		}

		[Test]
		public void ViewOnLoaded_SetsDefaultTimeInterval()
		{
			// arrange
			var presenter = BuildPresenter();
			var expectedInterval = new DateInterval(DateTime.Today.AddDays(-7), DateTime.Today);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.SetDateInterval(It.Is<DateInterval>(y => y.Equals(expectedInterval))), Times.Once());
		}

		[Test]
		public void ViewOnLoaded_ShouldLoadTypesInView()
		{
			// arrange
			var presenter = BuildPresenter();

			var types = new List<string>();
			_repository.Setup(x => x.GetTypes()).Returns(types);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadTypes(types), Times.Once());
		}

		[Test]
		public void ViewOnLoaded_ShouldLoadSourcesInView()
		{
			// arrange
			var presenter = BuildPresenter();

			var sources = new List<string>();
			_repository.Setup(x => x.GetSources()).Returns(sources);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadSources(sources), Times.Once());
		}

		[Test]
		public void ViewOnLoaded_ShouldLoadUsersInView()
		{
			// arrange
			var presenter = BuildPresenter();

			var users = new List<string>();
			_repository.Setup(x => x.GetUsers()).Returns(users);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadUsers(users), Times.Once());
		}

		[Test]
		public void ViewOnLoaded_ShouldLoadUrlsInView()
		{
			// arrange
			var presenter = BuildPresenter();

			var urls = new List<string>();
			_repository.Setup(x => x.GetUrls()).Returns(urls);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadUrls(urls), Times.Once());
		}
		
		[Test]
		public void OnFilterApplied_ShouldClearErrorDetails()
		{
			// arrange
			var presenter = BuildPresenter();
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
			var presenter = BuildPresenter();
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
			var presenter = BuildPresenter();
			var error = new ErrorLog();

			// act
			_view.Raise(x => x.OnErrorLogSelected += null, new ErrorLogSelectedEventArgs(error));

			// assert
			_view.Verify(x => x.DisplayErrorDetails(error), Times.Once());
		}

		[Test]
		public void OnRepositoryInitialized_ShouldClearView()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_repository.Raise(x => x.OnInitialized += null, new RepositoryInitializedEventArgs(string.Empty, 0));

			// assert
			_view.Verify(x => x.ClearResult(), Times.Once());
			_view.Verify(x => x.ClearErrorDetails(), Times.Once());
		}

		[Test]
		public void OnRepositoryInitialized_ShouldLoadTypesInView()
		{
			// arrange
			var presenter = BuildPresenter();
			var types = new List<string>();
			_repository.Setup(x => x.GetTypes()).Returns(types);

			// act
			_repository.Raise(x => x.OnInitialized += null, new RepositoryInitializedEventArgs(string.Empty, 0));

			// assert
			_view.Verify(x => x.LoadTypes(types), Times.Once());
		}

		[Test]
		public void OnRepositoryInitialized_ShouldLoadSourcesInView()
		{
			// arrange
			var presenter = BuildPresenter();
			var sources = new List<string>();
			_repository.Setup(x => x.GetSources()).Returns(sources);

			// act
			_repository.Raise(x => x.OnInitialized += null, new RepositoryInitializedEventArgs(string.Empty, 0));

			// assert
			_view.Verify(x => x.LoadSources(sources), Times.Once());
		}

		[Test]
		public void OnRepositoryInitialized_ShouldLoadUsersInView()
		{
			// arrange
			var presenter = BuildPresenter();
			var users = new List<string>();
			_repository.Setup(x => x.GetUsers()).Returns(users);

			// act
			_repository.Raise(x => x.OnInitialized += null, new RepositoryInitializedEventArgs(string.Empty, 0));

			// assert
			_view.Verify(x => x.LoadUsers(users), Times.Once());
		}

		private SearchPresenter BuildPresenter()
		{
			return new SearchPresenter(_view.Object, _repository.Object, _searchLauncher.Object);
		}
	}
}
