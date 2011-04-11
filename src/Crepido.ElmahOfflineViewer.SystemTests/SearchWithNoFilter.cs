using NUnit.Framework;
using White.Core;
using White.Core.Factory;
using White.Core.UIItems;

namespace Crepido.ElmahOfflineViewer.SystemTests
{
	//// team city build agent service must be allowed to interact with desktop
	//// for ui tests to work.

	[TestFixture]
	public class SearchWithNoFilter
	{
		private const string ApplicationName = @"..\..\..\..\_build\Crepido.ElmahOfflineViewer.UI.exe";
		private Application _app;

		[SetUp]
		public void Setup()
		{
			_app = Application.Launch(ApplicationName);
		}

		[TearDown]
		public void TearDown()
		{
			_app.Kill();
		}

		/// <summary>
		/// http://white.codeplex.com/discussions/246193
		/// </summary>
		[Test, Ignore]
		public void RunTest()
		{
			// arrange
			var window = _app.GetWindow("Crepido ELMAH Offline Viewer", InitializeOption.NoCache);
			Assert.That(window, Is.Not.Null, "Window not found");

			var serchButton = window.Get<Button>("_filterButton");
			Assert.That(serchButton, Is.Not.Null, "Search button not found");

			// act
			serchButton.Click();

			var treeview = window.Get<White.Core.UIItems.TreeItems.Tree>("resultTreeView");
			Assert.That(treeview.Nodes.Count, Is.EqualTo(2), "Invalid number of results in tree view");
		}
	}
}
