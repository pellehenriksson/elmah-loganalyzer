using System;
using System.Data.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLogSourceServiceFactory
	{
		public IErrorLogSourceService Build(string path)
		{
			if (IsConnectionString(path))
			{
				return new SqlServerErrorLogSourceService(null, null, null);
			}

			return new FileErrorLogSourceService(null, null, null);
		}

		private static bool IsConnectionString(string path)
		{
			try
			{
				var builder = new DbConnectionStringBuilder { ConnectionString = path };
				return true;
			}
			catch (ArgumentException)
			{
				return false;
			}
		}
	}
}
