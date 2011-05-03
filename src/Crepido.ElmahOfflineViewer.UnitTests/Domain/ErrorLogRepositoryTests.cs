using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ErrorLogRepositoryTests : UnitTestBase
	{
		[Test]
		public void Initialize_SetsDirectory()
		{
			// arrange
			var repository = CreateRepository();
			repository.Initialize(FakeLogsDirectory);

			// act
			var result = repository.Directory;

			// assert
			Assert.That(result, Is.EqualTo(FakeLogsDirectory));
		}

		[Test]
		public void Initilize_LoadsErrorLogsIntoMemory()
		{
			// arrange
			var repository = CreateRepository();

			// act
			repository.Initialize(FakeLogsDirectory);
			
			// assert
			Assert.That(repository.GetAll().Count, Is.EqualTo(4));
		}

		[Test]
		public void Initilize_LoadsTypesIntoMemory()
		{
			// arrange
			var repository = CreateRepository();

			// act
			repository.Initialize(FakeLogsDirectory);

			// assert
			Assert.That(repository.GetTypes().Count, Is.EqualTo(2));
		}
		
		[Test]
		public void Initilize_LoadsUsersIntoMemory()
		{
			// arrange
			var repository = CreateRepository();

			// act
			repository.Initialize(FakeLogsDirectory);

			// assert
			Assert.That(repository.GetUsers().Count, Is.EqualTo(3));
		}

		[Test]
		public void Initilize_LoadsSourcesIntoMemory()
		{
			// arrange
			var repository = CreateRepository();

			// act
			repository.Initialize(FakeLogsDirectory);

			// assert
			Assert.That(repository.GetSources().Count, Is.EqualTo(3));
		}

		[Test]
		public void Initialize_LoadUrlsIntoMemory()
		{
			// arrange
			var repository = CreateRepository();

			// act
			repository.Initialize(FakeLogsDirectory);

			// assert
			Assert.That(repository.GetUrls().Count, Is.EqualTo(2));
		}

		[Test]
		public void OnInitialized_IsRasiedAfterInitialize()
		{
			// arrange
			var repository = CreateRepository();

			var eventWasRaised = false;
			repository.OnInitialized += delegate { eventWasRaised = true; };

			// act
			repository.Initialize(FakeLogsDirectory);

			// assert
			Assert.That(eventWasRaised, Is.True);
		}

		[Test]
		public void OnInitialized_HasDirectory()
		{
			// arrange
			var repository = CreateRepository();

			var directory = string.Empty;
			repository.OnInitialized += delegate(object sender, RepositoryInitializedEventArgs args) { directory = args.Directory; };

			// act
			repository.Initialize(FakeLogsDirectory);

			// assert
			Assert.That(directory, Is.EqualTo(repository.Directory));
		}

		[Test]
		public void GetWithFilter_StartAndEndTime()
		{
			var query = new SearchErrorLogQuery { Interval = new DateInterval(new DateTime(2011, 1, 1), new DateTime(2011, 1, 3)) };
			GetWithFilterTest(query, 3);
		}

		[Test]
		public void GetWithFilter_StartAndEndTimeAndType()
		{
			var query = new SearchErrorLogQuery { Interval = CreateInterval(), Type = "System.SomeOtherException" };
			GetWithFilterTest(query, 2);
		}

		[Test]
		public void GetWithFilter_StartAndEndTimeAndSource()
		{
			var query = new SearchErrorLogQuery { Interval = CreateInterval(), Source = "Some.Namespace.Domain" };
			GetWithFilterTest(query, 2);
		}

		[Test]
		public void GetWithFilter_StartAndEndTimeAndUser()
		{
			var query = new SearchErrorLogQuery { Interval = CreateInterval(), User = "nisse" };
			GetWithFilterTest(query, 1);
		}

		[Test]
		public void GetWithFilter_StartAndEndTimeAndText()
		{
			var query = new SearchErrorLogQuery { Interval = CreateInterval(), Text = "serious" };
			GetWithFilterTest(query, 1);
		}

		[Test]
		public void GetWithFilter_StartAndEndTimeAndUrl()
		{
			var query = new SearchErrorLogQuery { Interval = CreateInterval(), Url = "some/path" };
			GetWithFilterTest(query, 2);
		}
		
		private static void GetWithFilterTest(SearchErrorLogQuery query, int expectedResult)
		{
			// arrange
			var repository = CreateRepository();

			// act
			var result = repository.GetWithFilter(query);

			// assert
			Assert.That(result.Count, Is.EqualTo(expectedResult));
		}
		
		private static IErrorLogRepository CreateRepository()
		{
			var repository = new ErrorLogRepository(new FakeDataSourceService(), new FakeClientInformationResolver());
			repository.Initialize(string.Empty);
			return repository;
		}

		private static DateInterval CreateInterval()
		{
			return new DateInterval(new DateTime(2011, 1, 1), new DateTime(2011, 1, 4));
		}
	}
}
