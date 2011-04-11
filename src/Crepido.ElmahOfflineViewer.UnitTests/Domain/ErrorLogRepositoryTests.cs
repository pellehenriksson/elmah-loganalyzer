using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Moq;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ErrorLogRepositoryTests : UnitTestBase
	{
		private Mock<IDataSourceService> _datasourceService;

		[SetUp]
		public void Setup()
		{
			_datasourceService = new Mock<IDataSourceService>();
		}

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

		private IErrorLogRepository CreateRepository()
		{
			var repository = new ErrorLogRepository(_datasourceService.Object);

			ConnfigureFilesystemService();

			return repository;
		}

		private void ConnfigureFilesystemService()
		{
			var errors = CreateErrorLogs();
			_datasourceService.Setup(x => x.GetLogs(It.IsAny<string>())).Returns(errors);
		}
	}
}
