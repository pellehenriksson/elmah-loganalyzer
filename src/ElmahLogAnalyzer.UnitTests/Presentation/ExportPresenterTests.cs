using System;
using ElmahLogAnalyzer.Core.Domain.Export;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;
using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ExportPresenterTests : UnitTestBase
	{
		private Mock<IExportView>_view;
		private Mock<IErrorLogExporter> _exporter;
		private Mock<ISettingsManager> _settings;

		[SetUp]
		public void Setup()
		{
			_view = new Mock<IExportView>();
			_exporter = new Mock<IErrorLogExporter>();
			_settings = new Mock<ISettingsManager>();

			_settings.Setup(x => x.GetDefaultExportDirectory()).Returns(@"c:\logs");
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
		public void OnLoaded_SetsDefaultExportDirectory()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.VerifySet(x => x.ExportToDirectory = @"c:\logs", Times.Once());
		}

		[Test]
		public void OnExport_SetsViewInLoadingState()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_view.Raise(x => x.OnExport += null, new EventArgs());

			// assert
			_view.Verify(x => x.SetLoadingState(), Times.Once());
		}
		
		[Test][Ignore("The test sometimes fails, probably a thearding issue with Task")]
		public void OnExport_Exports()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_view.Raise(x => x.OnExport += null, new EventArgs());

			// assert
			_exporter.Verify(x => x.Export(), Times.Once());
		}

		[Test]
		public void OnCancel_CancelsExport()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_view.Raise(x => x.OnCancel += null, new EventArgs());

			// assert
			_exporter.Verify(x => x.Cancel(), Times.Once());
		}

		[Test]
		public void OnCancel_ClosesView()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_view.Raise(x => x.OnCancel += null, new EventArgs());

			// assert
			_view.Verify(x => x.CloseView(), Times.Once());
		}

		[Test]
		public void OnExport_ExportSuccessful_ClosesView()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_exporter.Raise(x => x.OnCompleted += null, new EventArgs());
			
			// assert
			_view.Verify(x => x.CloseView(), Times.Once());
		}

		[Test]
		public void OnExport_ExportFails_DisplaysError()
		{
			// arrange
			var presenter = BuildPresenter();
			var error = new ApplicationException("Hello world");

			// act
			_exporter.Raise(x => x.OnError += null, new ErrorLogExporterErrorEventArgs(error));

			// assert
			_view.Verify(x => x.DisplayError(error), Times.Once());
		}

		[Test]
		public void OnExport_ProgressChanged_DisplaysProgress()
		{
			// arrange
			var presenter = BuildPresenter();

			// act
			_exporter.Raise(x => x.OnProgressChanged += null, new ErrorLogExporterProgressEventArgs("hello world"));

			// assert
			_view.Verify(x => x.DisplayProgress("hello world"), Times.Once());
		}

		private ExportPresenter BuildPresenter()
		{
			return new ExportPresenter(_view.Object, _exporter.Object, _settings.Object);
		}
	}
}
