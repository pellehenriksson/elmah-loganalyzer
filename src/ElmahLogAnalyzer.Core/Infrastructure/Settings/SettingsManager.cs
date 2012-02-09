using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Infrastructure.Settings
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

		public string GetDefaultLogsDirectory()
		{
			return UserSettings.Default.DefaultLogsDirectory;
		}

		public void SetDefaultLogsDirectory(string directory)
		{
			UserSettings.Default.DefaultLogsDirectory = directory;
		}

		public bool GetLoadLogsFromDefaultDirectoryAtStartup()
		{
			return UserSettings.Default.LoadLogsFromDefaultDirectoryAtStartup;
		}

		public void SetLoadLogsFromDefaultDirectoryAtStartup(bool shouldLoad)
		{
			UserSettings.Default.LoadLogsFromDefaultDirectoryAtStartup = shouldLoad;
		}

		public string GetDefaultExportDirectory()
		{
			return UserSettings.Default.DefaultExportDirectory;
		}

		public void SetDefaultExportDirectory(string directory)
		{
			UserSettings.Default.DefaultExportDirectory = directory;
		}

		public DateIntervalSpanEnum GetDefaultDateInterval()
		{
			return (DateIntervalSpanEnum)UserSettings.Default.DefaultDateInterval;
		}

		public void SetDefaultDateInterval(DateIntervalSpanEnum interval)
		{
			UserSettings.Default.DefaultDateInterval = (int)interval;
		}

		public void Save()
		{
			UserSettings.Default.Save();
		}
	}
}
