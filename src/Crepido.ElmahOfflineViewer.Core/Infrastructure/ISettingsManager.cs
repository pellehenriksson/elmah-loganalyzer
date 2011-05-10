using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	public interface ISettingsManager
	{
		int GetMaxNumberOfLogs();

		void SetMaxNumberOfLogs(int maxNumberOfLogs);

		void Save();
	}
}
