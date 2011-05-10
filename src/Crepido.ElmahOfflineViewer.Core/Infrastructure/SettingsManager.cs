using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure
{
	public class SettingsManager : ISettingsManager
	{
		public int GetMaxNumberOfLogs()
		{
			return UserSettings.Default.MaxNumberOfLogs;
		}

		public void SetMaxNumberOfLogs(int maxNumberOfLogs)
		{
			UserSettings.Default.MaxNumberOfLogs = maxNumberOfLogs;
		}

		public void Save()
		{
			UserSettings.Default.Save();
		}
	}
}
