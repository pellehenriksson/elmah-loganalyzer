namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class YellowScreenOfDeathBuilder
	{
		public YellowScreenOfDeathBuilder(ErrorLog errorlog)
		{
			ErrorLog = errorlog;
		}

		public ErrorLog ErrorLog { get; private set; }

		public string Application { get; private set; }

		public string ExceptionDetails { get; private set; }

		public string SourceError { get; private set; }

		public string SourceFile { get; private set; }

		public string StackTrace { get; private set; }

		public string VersionInformation { get; private set; }
	}
}
