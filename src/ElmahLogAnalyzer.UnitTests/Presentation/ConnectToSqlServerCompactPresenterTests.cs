using System;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class ConnectToSqlServerCompactPresenterTests : UnitTestBase
	{
		private Mock<IConnectToSqlServerCompactView> _view;
		private Mock<IFileSystemHelper> _fileSystemHelper;

		[SetUp]
		public void Setup()
		{
			_view = new Mock<IConnectToSqlServerCompactView>();
			_fileSystemHelper = new Mock<IFileSystemHelper>();
		}

		[Test]
		public void Ctor_SetsView()
		{
			// act
			var presenter = new ConnectToSqlServerCompactPresenter(_view.Object, _fileSystemHelper.Object);

			// assert
			Assert.That(presenter.View, Is.EqualTo(_view.Object));
		}

		[Test]
		public void OnConnectToDatabase_NoFile_DisplaysErrorMessage()
		{
			// arrange
			var presenter = new ConnectToSqlServerCompactPresenter(_view.Object, _fileSystemHelper.Object);
			_view.Setup(x => x.Server).Returns(string.Empty);

			// act
			_view.Raise(x => x.OnConnectToDatabase += null, new EventArgs());

			// assert
			_view.Verify(x => x.DisplayErrorMessage("No file selected"), Times.Once());
		}

		[Test]
		public void OnConnectToDatabase_FileNotFoundOnDisk_DisplaysErrorMessage()
		{
			// arrange
			var presenter = new ConnectToSqlServerCompactPresenter(_view.Object, _fileSystemHelper.Object);
			_view.Setup(x => x.Server).Returns(@"c:\elmah.sdf");
			_fileSystemHelper.Setup(x => x.FileExists(_view.Object.Server)).Returns(false);

			// act
			_view.Raise(x => x.OnConnectToDatabase += null, new EventArgs());

			// assert
			_view.Verify(x => x.DisplayErrorMessage("File does not exist"), Times.Once());
		}

		[Test]
		public void OnConnectToDatabase_ValidFile_ClosesView()
		{
			// arrange
			var presenter = new ConnectToSqlServerCompactPresenter(_view.Object, _fileSystemHelper.Object);
			_view.Setup(x => x.Server).Returns(@"c:\elmah.sdf");
			_fileSystemHelper.Setup(x => x.FileExists(_view.Object.Server)).Returns(true);

			// act
			_view.Raise(x => x.OnConnectToDatabase += null, new EventArgs());

			// assert
			_view.Verify(x => x.CloseView());
		}
	}
}
