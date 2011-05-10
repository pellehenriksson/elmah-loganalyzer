/*
using System;
using System.Linq;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests
{
	[TestFixture]
	public class Sandbox
	{
		[Test, Ignore]
		public void SpitOut()
		{
			var logger = new FakeLog();
			var source = new FileDataSourceService(new ErrorLogFileParser(logger), logger);
			var repository = new ErrorLogRepository(source, new FakeClientInformationResolver());

			const string path = "c:\\temp\\elmah";
			repository.Initialize(path);

			var logs = repository.GetAll();

			foreach (var log in logs)
			{
				var httpUserAgent = log.ServerVariables.FirstOrDefault(x => x.Name.Equals("HTTP_USER_AGENT", StringComparison.InvariantCultureIgnoreCase));
				if (httpUserAgent != null)
				{
					Console.Out.WriteLine(httpUserAgent.Value);
				}
			}
		}
	}
}
*/