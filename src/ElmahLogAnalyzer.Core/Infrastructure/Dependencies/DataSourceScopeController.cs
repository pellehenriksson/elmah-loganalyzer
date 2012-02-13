using System;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Infrastructure.Dependencies
{
	public static class DataSourceScopeController
	{
		private static object _keepAlive = new object();

		public static string Source { get; private set; }
		
		public static string Connection { get; private set; }

		public static object KeepAlive
		{
			get { return _keepAlive; }
		}

		public static void SetNewSource(string source, string connection)
		{
			if (!source.HasValue())
			{
				throw new InvalidOperationException("The source is undefined");
			}

			Source = source;
			Connection = connection;

			_keepAlive = new object();
		}
	}
}
