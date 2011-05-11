using System;
using System.Data.Common;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLogSourceFactory : IErrorLogSourceFactory
	{
		public IErrorLogSource Build(string path)
		{
			if (IsConnectionString(path))
			{
				// todo: resolve with ninject
				return new SqlServerErrorLogSource(null, null, null, null);
			}

			// todo: resolve with ninject
			return new FileErrorLogSource(null, null, null);
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
