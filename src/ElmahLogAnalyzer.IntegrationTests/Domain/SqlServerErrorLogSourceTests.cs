using System;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.TestHelpers.Fakes;
using NUnit.Framework;

namespace ElmahLogAnalyzer.IntegrationTests.Domain
{
	[TestFixture][Ignore]
	public class SqlServerErrorLogSourceTests 
	{
		[Test]
		public void Fetch_Logs_From_Database()
		{
			var source = CreateSource();
			var result = source.GetLogs();

			foreach (var r in result)
			{
				Console.Out.WriteLine(r.Time);
				Console.Out.WriteLine(r.Source);
				Console.Out.WriteLine(r.Message);
			}
		}

		[Test]
		public void Wrapp_With_Repository()
		{
			var source = CreateSource();
			var repository = new ErrorLogRepository(source);

			repository.Initialize();

			var result = repository.GetAll();
			
			foreach (var r in result)
			{
				Console.Out.WriteLine(r.Time);
				Console.Out.WriteLine(r.Source);
				Console.Out.WriteLine(r.Message);
			}
		}

		private static SqlServerErrorLogSource CreateSource()
		{
			var settings = new FakeSettingsManager();
			settings.SetMaxNumberOfLogs(100);

			return new SqlServerErrorLogSource(@"data source=.\SQLEXPRESS;Initial Catalog=ElmahLogAnalyzer;Integrated Security=SSPI", new ErrorLogFileParser(new FakeLog(), new ClientInformationResolver()), settings, new FakeLog());
		}
	}
}
