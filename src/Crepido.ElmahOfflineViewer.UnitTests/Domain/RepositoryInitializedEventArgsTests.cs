using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class RepositoryInitializedEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsDirectory()
		{
			// act
			var args = new RepositoryInitializedEventArgs(FakeLogsDirectory, 10);

			// assert
			Assert.That(args.Directory, Is.EqualTo(FakeLogsDirectory));
		}

		[Test]
		public void Ctor_SetsTotalNumberOfLogs()
		{
			// act
			var args = new RepositoryInitializedEventArgs(FakeLogsDirectory, 10);

			// assert
			Assert.That(args.TotalNumberOfLogs, Is.EqualTo(10));
		}
	}
}
