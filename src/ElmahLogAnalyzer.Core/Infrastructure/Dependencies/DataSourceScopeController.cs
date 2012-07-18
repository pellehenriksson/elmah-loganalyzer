using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Infrastructure.Dependencies
{
	public static class DataSourceScopeController
	{
		private static object _keepAlive = new object();

		public static ErrorLogSources Source { get; private set; }
		
		public static string Connection { get; private set; }

		public static string Schema { get; private set; }

		public static object KeepAlive
		{
			get { return _keepAlive; }
		}

		public static void SetNewSource(ErrorLogSources source, string connection, string schema)
		{
			Source = source;
			Connection = connection;
			Schema = schema;

			_keepAlive = new object();
		}
	}
}
