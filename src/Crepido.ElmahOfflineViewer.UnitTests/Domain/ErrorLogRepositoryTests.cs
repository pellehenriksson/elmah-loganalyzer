using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.UnitTests._Fakes;
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
			// arrange
			var repository = CreateRepository();
			var query = new SearchErrorLogQuery { StartTime = new DateTime(2011, 1, 1), EndTime = new DateTime(2011, 1, 3) };

			// act
			var result = repository.GetWithFilter(query);

			// assert
			Assert.That(result.Count, Is.EqualTo(3));
		}
		
		private static IErrorLogRepository CreateRepository()
		{
			var repository = new ErrorLogRepository(new FakeDataSourceService());
			repository.Initialize(string.Empty);
			return repository;
		}
	}
}
