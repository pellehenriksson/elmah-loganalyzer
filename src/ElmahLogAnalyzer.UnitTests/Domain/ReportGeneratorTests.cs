using System;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain
{
	[TestFixture]
	public class ReportGeneratorTests : UnitTestBase
	{
		[Test]
		public void Create_ReportTypeIsType_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Type, CreateInterval(), -1);

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(3));
		}

		[Test]
		public void Create_ReportTypeIsTypeNumerOfResultsIsTwo_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Type, CreateInterval(), 2);

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
			var query = new ReportQuery(ReportTypeEnum.Source, CreateInterval(), -1);

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(4));
		}

		[Test]
		public void Create_ReportTypeIsSourceNumberOfResultsIsThree_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Source, CreateInterval(), 3);

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
			var query = new ReportQuery(ReportTypeEnum.User, CreateInterval(), -1);

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(4));
		}

		[Test]
		public void Create_ReportTypeIsUserNumberOfResultsIsTwo_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.User, CreateInterval(), 2);

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(2));
		}
		
		[Test]
		public void Create_ReportTypeIsUrl_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Url, CreateInterval(), -1);

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(3));
		}

		[Test]
		public void Create_ReportTypeIsUrlNumberOfResultsIsOne_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Url, CreateInterval(), 1);

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(1));
		}
		
		[Test]
		public void Create_ReportTypeIsDay_GeneratesReport()
		{
			// arrange
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Day, CreateInterval(), -1);

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
			var repository = new ErrorLogRepository(new FakeDataSource(), new FakeClientInformationResolver());
			repository.Initialize(string.Empty);

			return new ReportGenerator(repository);
		}

		private static DateInterval CreateInterval()
		{
			return new DateInterval(new DateTime(2011, 1, 1), new DateTime(2011, 4, 8));
		}
	}
}
