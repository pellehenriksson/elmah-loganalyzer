using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
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
			var generator = CreateGenerator();
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
			var generator = CreateGenerator();
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
			var generator = CreateGenerator();
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
			var generator = CreateGenerator();
			var query = new ReportQuery(ReportTypeEnum.Day, new DateTime(2011, 1, 1), new DateTime(2011, 4, 8));

			// act
			var result = generator.Create(query);

			// assert
			Assert.That(result.Items.Count, Is.EqualTo(4));
		}
		
		private static IReportGenerator CreateGenerator()
		{
			var repository = new ErrorLogRepository(new FakeDataSourceService());
			repository.Initialize(string.Empty);

			return new ReportGenerator(repository);
		}
	}
}
