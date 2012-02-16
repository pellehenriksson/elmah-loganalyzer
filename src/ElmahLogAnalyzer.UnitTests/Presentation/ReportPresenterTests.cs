using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;
using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ReportPresenterTests : UnitTestBase
	{
		private Mock<IReportView> _view;
		private Mock<IReportGenerator> _generator;
		private Mock<ISettingsManager> _settings;

		[SetUp]
		public void Setup()
		{
			_view = new Mock<IReportView>();
			_generator = new Mock<IReportGenerator>();
			_settings = new Mock<ISettingsManager>();

			_settings.Setup(x => x.GetDefaultDateInterval()).Returns(DateIntervalSpans.Month);
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
		public void ViewOnLoaded_SetsDefaultTimeIntervalWithValueFromSettings()
		{
			// arrange
			var presenter = BuildPresenter();
			var expectedInterval = new DateInterval(DateTime.Today.AddMonths(-1), DateTime.Today);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.SetDateInterval(It.Is<DateInterval>(y => y.Equals(expectedInterval))), Times.Once());
		}
		
		[Test]
		public void ViewOnLoaded_LoadReportTypes()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadReportTypes(It.IsAny<List<ReportTypeListItem>>()), Times.Once());
		}

		[Test]
		public void ViewOnLoaded_LoadNumberOfResultsOptions()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadNumberOfResultsOptions(It.IsAny<List<NameValuePair>>()), Times.Once());
		}

		[Test]
		public void ViewOnReportSelected_DisplaysReport()
		{
			// arrange
			var presenter = BuildPresenter();
			var reporyQuery = CreateReportQuery();
			var args = new ReportSelectionEventArgs(reporyQuery);

			var report = new Report(reporyQuery);
			_generator.Setup(x => x.Create(reporyQuery)).Returns(report);

			// act
			_view.Raise(x => x.OnReportSelected += null, args);

			// assert
			_view.Verify(x => x.DisplayReport(report), Times.Once());
		}

		[Test]
		public void GeneratorOnDataSourceInitialized_ClearsView()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_generator.Raise(x => x.OnDataSourceInitialized += null, new EventArgs());

			// assert
			_view.Verify(x => x.Clear(), Times.Once());
		}

		private ReportPresenter BuildPresenter()
		{
			return new ReportPresenter(_view.Object, _generator.Object, _settings.Object);
		}
	}
}
