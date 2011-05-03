using System;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Abstract;
using NLog;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	public class Log : ILog
	{
		private readonly Logger _logger;

		public Log(Logger logger)
		{
			_logger = logger;
		}

		public void Debug(string message)
		{
			_logger.Debug(message);
		}

		public void Error(string message)
		{
			_logger.Error(message);
		}

		public void Error(string message, Exception exception)
		{
			_logger.ErrorException(message, exception);
		}

		public void Error(Exception exception)
		{
			_logger.Error(exception);
		}
	}
}
