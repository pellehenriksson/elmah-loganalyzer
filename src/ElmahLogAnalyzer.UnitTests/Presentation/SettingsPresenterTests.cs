using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;
using ElmahLogAnalyzer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Presentation
{
	[TestFixture]
	public class SettingsPresenterTests : UnitTestBase
	{
		private Mock<ISettingsView> _view;
		private Mock<ISettingsManager> _userSettingsManager;

		[SetUp]
		public void Setup()
		{
			_view = new Mock<ISettingsView>();
			_userSettingsManager = new Mock<ISettingsManager>();

			_userSettingsManager.Setup(x => x.GetMaxNumberOfLogs()).Returns(500);
			_userSettingsManager.Setup(x => x.GetDefaultDateInterval()).Returns(DateIntervalSpanEnum.Month);
			_userSettingsManager.Setup(x => x.GetDefaultExportDirectory()).Returns(@"c:\exportedlogs");
			_userSettingsManager.Setup(x => x.GetDefaultLogsDirectory()).Returns(@"c:\mylogs");
			_userSettingsManager.Setup(x => x.GetLoadLogsFromDefaultDirectoryAtStartup()).Returns(true);
		}

		[Test]
		public void Ctor_SetsView()
		{
			// act
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);
			
			// assert
			Assert.That(presenter.View, Is.EqualTo(_view.Object));
		}

		[Test]
		public void ViewOnLoaded_DisplaysMaxNumberOfLogsOptionsAndUsersSelectedValue()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);
			
			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadMaxNumberOfLogOptions(It.IsAny<List<NameValuePair>>(), "500"), Times.Once());
		}

		[Test]
		public void ViewOnLoaded_DisplaysDefaultDateIntervalOptionsAndUsersSelectedValue()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadDefaultDateIntervalOptions(It.IsAny<IEnumerable<NameValuePair>>(), DateIntervalSpanEnum.Month), Times.Once());
		}
		
		[Test]
		public void ViewOnLoaded_DisplaysDefaultExportDirectory()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.VerifySet(x => x.DefaultExportDirectory = @"c:\exportedlogs", Times.Once());
		}

		[Test]
		public void ViewOnLoaded_DisplaysLoadLogsFromDefaultDirectoryAtStartup()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.VerifySet(x => x.LoadLogsFromDefaultDirectoryAtStartup = true, Times.Once());
		}
		
		[Test]
		public void ViewOnLoaded_DisplaysDefaultLogsDirectory()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.VerifySet(x => x.DefaultLogsDirectory = @"c:\mylogs", Times.Once());
		}

		[Test]
		public void ViewOnSave_SavesMaxNumberOfLogsOption()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			_view.Setup(x => x.MaxNumberOfLogs).Returns(200);

			// act
			_view.Raise(x => x.OnSave += null, new EventArgs());

			// assert
			_userSettingsManager.Verify(x => x.SetMaxNumberOfLogs(200), Times.Once());
		}

		[Test]
		public void ViewOnSave_DefaultDateIntervalOption()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			_view.Setup(x => x.DefaultDateInterval).Returns(DateIntervalSpanEnum.Year);

			// act
			_view.Raise(x => x.OnSave += null, new EventArgs());

			// assert
			_userSettingsManager.Verify(x => x.SetDefaultDateInterval(DateIntervalSpanEnum.Year), Times.Once());
		}
		
		[Test]
		public void ViewOnSave_SavesDefaultExportDirectory()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			_view.Setup(x => x.DefaultExportDirectory).Returns(@"c:\exportedlogs");

			// act
			_view.Raise(x => x.OnSave += null, new EventArgs());

			// assert
			_userSettingsManager.Verify(x => x.SetDefaultExportDirectory(@"c:\exportedlogs"), Times.Once());
		}

		[Test]
		public void ViewOnSave_SavesDefaultLogsDirectory()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			_view.Setup(x => x.DefaultLogsDirectory).Returns(@"c:\mylogs");

			// act
			_view.Raise(x => x.OnSave += null, new EventArgs());

			// assert
			_userSettingsManager.Verify(x => x.SetDefaultLogsDirectory(@"c:\mylogs"), Times.Once());
		}

		[Test]
		public void ViewOnSave_SavesLoadLogsFromDefaultDirectoryAtStartup()
		{
			// arrange
			var presenter = new SettingsPresenter(_view.Object, _userSettingsManager.Object);

			_view.Setup(x => x.LoadLogsFromDefaultDirectoryAtStartup).Returns(true);

			// act
			_view.Raise(x => x.OnSave += null, new EventArgs());

			// assert
			_userSettingsManager.Verify(x => x.SetLoadLogsFromDefaultDirectoryAtStartup(true), Times.Once());
		}
	}
}
