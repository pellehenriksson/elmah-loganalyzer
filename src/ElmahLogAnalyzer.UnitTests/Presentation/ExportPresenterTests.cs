using System;
using ElmahLogAnalyzer.Core.Domain.Export;
using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ExportPresenterTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsView()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();

			// act
			var presenter = new ExportPresenter(view.Object, exporter.Object);
			
			// assert
			Assert.That(presenter.View, Is.EqualTo(view.Object));
		}

		[Test]
		public void OnExport_SetsViewInLoadingState()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();
			var presenter = new ExportPresenter(view.Object, exporter.Object);

			// act
			view.Raise(x => x.OnExport += null, new EventArgs());

			// assert
			view.Verify(x => x.SetLoadingState(), Times.Once());
		}
		
		[Test][Ignore("The test sometimes fails, probably a thearding issue with Task")]
		public void OnExport_Exports()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();
			var presenter = new ExportPresenter(view.Object, exporter.Object);

			// act
			view.Raise(x => x.OnExport += null, new EventArgs());

			// assert
			exporter.Verify(x => x.Export(), Times.Once());
		}

		[Test]
		public void OnCancel_CancelsExport()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();
			var presenter = new ExportPresenter(view.Object, exporter.Object);

			// act
			view.Raise(x => x.OnCancel += null, new EventArgs());

			// assert
			exporter.Verify(x => x.Cancel(), Times.Once());
		}

		[Test]
		public void OnCancel_ClosesView()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();
			var presenter = new ExportPresenter(view.Object, exporter.Object);

			// act
			view.Raise(x => x.OnCancel += null, new EventArgs());

			// assert
			view.Verify(x => x.CloseView(), Times.Once());
		}

		[Test]
		public void OnExport_ExportSuccessful_ClosesView()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();
			var presenter = new ExportPresenter(view.Object, exporter.Object);

			// act
			exporter.Raise(x => x.OnCompleted += null, new EventArgs());
			
			// assert
			view.Verify(x => x.CloseView(), Times.Once());
		}

		[Test]
		public void OnExport_ExportFails_DisplaysError()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();
			var presenter = new ExportPresenter(view.Object, exporter.Object);
			var error = new ApplicationException("Hello world");

			// act
			exporter.Raise(x => x.OnError += null, new ErrorLogExporterErrorEventArgs(error));

			// assert
			view.Verify(x => x.DisplayError(error), Times.Once());
		}

		[Test]
		public void OnExport_ProgressChanged_DisplaysProgress()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();
			var presenter = new ExportPresenter(view.Object, exporter.Object);
			var error = new ApplicationException("Hello world");

			// act
			exporter.Raise(x => x.OnProgressChanged += null, new ErrorLogExporterProgressEventArgs("hello world"));

			// assert
			view.Verify(x => x.DisplayProgress("hello world"), Times.Once());
		}
	}
}
