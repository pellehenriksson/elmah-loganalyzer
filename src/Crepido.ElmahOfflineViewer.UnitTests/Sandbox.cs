using System;
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
	}
}
