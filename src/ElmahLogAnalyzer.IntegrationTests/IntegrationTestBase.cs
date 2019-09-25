using System.IO;
using System.Reflection;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Infrastructure.FileSystem;
using ElmahLogAnalyzer.TestHelpers.Fakes;

namespace ElmahLogAnalyzer.IntegrationTests
{
	public abstract class IntegrationTestBase
	{
		protected string TestSqlServerCompactDatabase
		{
			get { return Path.Combine(TestFilesDirectory, "elmah.sdf"); }
		}

		protected string TestAccessDatabase
		{
			get { return Path.Combine(TestFilesDirectory, "elmah.mdb"); }
		}

		protected string TestFilesDirectory
		{
            get
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                var dir = new System.Uri(path).LocalPath;

                return Path.Combine(dir, "_TestFiles");
            }
		}

		protected string TestArea
		{
			get { return Path.Combine(Directory.GetCurrentDirectory(), "_TestArea"); }
		}

		protected string TestCvsFile
		{
			get { return Path.Combine(TestFilesDirectory, "errorlog.csv"); }
		}

		protected string ExistingUrl
		{
			get { return "http://www.google.com"; }
		}

		protected string NonExistentUrl
		{
			get { return "http://www.bluttanblä.com"; }
		}

		protected ErrorLogRepository CreateRepository(int maxNumberOfLogs = -1)
		{
			var fileSystemHelper = new FileSystemHelper();
			var log = new FakeLog();
			var settings = new FakeSettingsManager();
			settings.SetMaxNumberOfLogs(maxNumberOfLogs);

			var parser = new ErrorLogFileParser(log, new ClientInformationResolver());
			var datasource = new FileErrorLogSource(TestFilesDirectory, fileSystemHelper, parser, settings, log);

			var repository = new ErrorLogRepository(datasource);
			return repository;
		}
	}
}
