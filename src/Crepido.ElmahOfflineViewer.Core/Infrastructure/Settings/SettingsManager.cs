using System;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings
{
	public class SettingsManager : ISettingsManager
	{
		public bool ShouldGetAllLogs
		{
			get { return GetMaxNumberOfLogs() == -1; }
		}

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
