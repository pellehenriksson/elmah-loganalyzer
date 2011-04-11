using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Moq;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ReportGeneratorTests : UnitTestBase
	{
		private Mock<IErrorLogRepository> _repository;

		[SetUp]
		public void Setup()
		{
			ConfigureRepository();
		}
		
		[Test]
		public void Create_ReportTypeIsType_GeneratesReport()
		{
			// arrange
			var generator = new ReportGenerator(_repository.Object);
			var query = new ReportQuery(ReportTypeEnum.Type, new DateTime(2011, 1, 1), new DateTime(2011, 4, 8));

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(2));
		}

		[Test]
		public void Create_ReportTypeIsSource_GeneratesReport()
		{
			// arrange
			var generator = new ReportGenerator(_repository.Object);
			var query = new ReportQuery(ReportTypeEnum.Source, new DateTime(2011, 1, 1), new DateTime(2011, 4, 8));

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(3));
		}

		[Test]
		public void Create_ReportTypeIsUser_GeneratesReport()
		{
			// arrange
			var generator = new ReportGenerator(_repository.Object);
			var query = new ReportQuery(ReportTypeEnum.User, new DateTime(2011, 1, 1), new DateTime(2011, 4, 8));

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(3));
		}
		
		[Test]
		public void Create_ReportTypeIsUrl_GeneratesReport()
		{
			// arrange
			var generator = new ReportGenerator(_repository.Object);
			var query = new ReportQuery(ReportTypeEnum.Url, new DateTime(2011, 1, 1), new DateTime(2011, 4, 8));

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(2));
		}

		[Test]
		public void Create_ReportTypeIsDay_GeneratesReport()
		{
			// arrange
			var generator = new ReportGenerator(_repository.Object);
			var query = new ReportQuery(ReportTypeEnum.Day, new DateTime(2011, 1, 1), new DateTime(2011, 4, 8));

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(4));
		}
		
		private void ConfigureRepository()
		{
			var errors = CreateErrorLogs();
			
			_repository = new Mock<IErrorLogRepository>();
			_repository.Setup(x => x.GetWithFilter(It.IsAny<SearchErrorLogQuery>())).Returns(errors);
		}
	}
}
