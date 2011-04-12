using System;
using System.Diagnostics;
using System.Threading;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests
{
	[TestFixture]
	public class Sandbox
	{
		[Test, Ignore]
		public void WriteOutUrls()
		{
			var repository = new ErrorLogRepository(new DataSourceService(new ErrorLogFileParser()));
			repository.Initialize(@"C:\Temp\ELMAH");

			foreach (var log in repository.GetAll())
			{
				Console.WriteLine(log.CleanUrl);
				Console.Out.WriteLine(log.Url);
				Console.WriteLine("-----------------------------------------------------------");
			}
		}

		[Test, Ignore]
		public void Try_StopWatch()
		{
			// arrange
			var watch = new Stopwatch();

			// act
			watch.Start();
			Thread.Sleep(1000);
			watch.Stop();

			// assert
			Console.Out.WriteLine(watch.Elapsed.Seconds);
		}
	}
}
