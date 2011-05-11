using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using Moq;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Presentation
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
			
			_userSettingsManager.Setup(x => x.GetMaxNumberOfLogs()).Returns(500);

			// act
			_view.Raise(x => x.OnLoaded += null, new EventArgs());

			// assert
			_view.Verify(x => x.LoadMaxNumberOfLogOptions(It.IsAny<List<NameValuePair>>(), "500"), Times.Once());
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
			_userSettingsManager.Verify(x => x.SetMaxNumberOfLogs(200));
		}
	}
}
