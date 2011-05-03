using System;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Abstract
{
	public interface ILog
	{
		void Debug(string message);

		void Error(string message);
		
		void Error(string message, Exception exception);
		
		void Error(Exception exception);
	}
}
