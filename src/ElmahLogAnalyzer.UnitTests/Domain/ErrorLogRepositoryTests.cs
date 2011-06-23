using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
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
			Assert.That(repository.GetAll().Count, Is.EqualTo(5));
		}

		[Test]
		public void Initilize_LoadsTypesIntoMemory()
		{
			// arrange
			var repository = CreateRepository();

			// act
			repository.Initialize(FakeLogsDirectory);

			// assert
			Assert.That(repository.GetTypes().Count, Is.EqualTo(3));
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
			Assert.That(repository.GetSources().Count, Is.EqualTo(4));
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
			var query = CreateQueryThatIncluedEverything();
			query.Interval = new DateInterval(new DateTime(2011, 1, 1), new DateTime(2011, 1, 3));
			
			GetWithFilterTest(query, 3);
		}

		[Test]
		public void GetWithFilter_StartAndEndTimeAndType()
		{
			var query = CreateQueryThatIncluedEverything();
			query.Interval = CreateIntervalThatIncludesEvertyhing();
			query.Types = new SearchErrorLogQueryParameter(true, new List<string> { "System.InvalidOperationException" });
			
			GetWithFilterTest(query, 2);
		}
		
		[Test]
		public void GetWithFilter_StartAndEndTimeAndSource()
		{
			var query = CreateQueryThatIncluedEverything();
			query.Interval = CreateIntervalThatIncludesEvertyhing();
			query.Sources = new SearchErrorLogQueryParameter(true, new List<string> { "Some.Namespace.Domain" });

			GetWithFilterTest(query, 2);
		}
		
		[Test]
		public void GetWithFilter_StartAndEndTimeAndUser()
		{
			var query = CreateQueryThatIncluedEverything();
			query.Interval = CreateIntervalThatIncludesEvertyhing();
			query.Users = new SearchErrorLogQueryParameter(true, new List<string> { "nisse" });

			GetWithFilterTest(query, 1);
		}
		
		[Test]
		public void GetWithFilter_StartAndEndTimeAndText()
		{
			var query = CreateQueryThatIncluedEverything();
			query.Interval = CreateIntervalThatIncludesEvertyhing();
			query.Text = "serious";

			GetWithFilterTest(query, 1);
		}

		[Test]
		public void GetWithFilter_StartAndEndTimeAndUrl()
		{
			var query = CreateQueryThatIncluedEverything();
			query.Interval = CreateIntervalThatIncludesEvertyhing();
			query.Urls = new SearchErrorLogQueryParameter(true, new List<string> { "some/path" });

			GetWithFilterTest(query, 2);
		}

		[Test]
		public void GetWithFilter_StartAndEndTimeExludeAllTypes()
		{
			var query = CreateQueryThatIncluedEverything();
			query.Interval = CreateIntervalThatIncludesEvertyhing();
			query.Types.IncludeItems = false;

			GetWithFilterTest(query, 0);
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
			var repository = new ErrorLogRepository(new FakeDataSource());
			repository.Initialize(string.Empty);
			return repository;
		}

		private static SearchErrorLogQuery CreateQueryThatIncluedEverything()
		{
			var repository = CreateRepository();
			var query = new SearchErrorLogQuery();

			query.Types = new SearchErrorLogQueryParameter(true, repository.GetTypes());
			query.Sources = new SearchErrorLogQueryParameter(true, repository.GetSources());
			query.Urls = new SearchErrorLogQueryParameter(true, repository.GetUrls());
			query.Users = new SearchErrorLogQueryParameter(true, repository.GetUsers());
			
			return query;
		}

		private static DateInterval CreateIntervalThatIncludesEvertyhing()
		{
			return new DateInterval(new DateTime(2011, 1, 1), new DateTime(2011, 1, 4));
		}
	}
}
