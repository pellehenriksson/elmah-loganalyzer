using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using Moq;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ReportGeneratorTests : UnitTestBase
	{
		[Test]
		public void Create_ReportTypeIsType_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Type, CreateInterval());

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(2));
		}

		[Test]
		public void Create_ReportTypeIsSource_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Source, CreateInterval());

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(3));
		}

		[Test]
		public void Create_ReportTypeIsUser_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.User, CreateInterval());

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(3));
		}
		
		[Test]
		public void Create_ReportTypeIsUrl_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Url, CreateInterval());

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(2));
		}

		[Test]
		public void Create_ReportTypeIsDay_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Day, CreateInterval());

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(4));
		}

		[Test]
		public void RepositoryOnInitialized_RaisesOnDataSourceInitializedEvent()
		{
			// arrange
			var repository = new Mock<IErrorLogRepository>();
			var generator = new ReportGenerator(repository.Object);
			var eventWasRaised = false;

			// act
			generator.OnDataSourceInitialized += delegate
			                                     	{
			                                     		eventWasRaised = true;
			                                     	};
			repository.Raise(x => x.OnInitialized += null, new RepositoryInitializedEventArgs(string.Empty, 0));

			// assert
			Assert.That(eventWasRaised, Is.True);
		}
		
		private static IReportGenerator CreateGenerator()
		{
			var repository = new ErrorLogRepository(new FakeDataSourceService(), new FakeClientInformationResolver());
			repository.Initialize(string.Empty);

			return new ReportGenerator(repository);
		}

		private static DateInterval CreateInterval()
		{
			return new DateInterval(new DateTime(2011, 1, 1), new DateTime(2011, 4, 8));
		}
	}
}
