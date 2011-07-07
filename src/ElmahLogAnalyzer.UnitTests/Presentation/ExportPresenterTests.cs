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

		[Test]
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
		public void OnExport_ExportSuccessful_ClosesView()
		{
			// arrange
			var view = new Mock<IExportView>();
			var exporter = new Mock<IErrorLogExporter>();
			var presenter = new ExportPresenter(view.Object, exporter.Object);

			// act
			view.Raise(x => x.OnExport += null, new EventArgs());

			// assert
			view.Verify(x => x.CloseView(), Times.Once());
		}
	}
}
