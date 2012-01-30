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

		public string GetDefaultExportLogsDirectory()
		{
			return UserSettings.Default.ExportLogsDirectory;
		}

		public void SetDefaultExportLogsDirectory(string directory)
		{
			UserSettings.Default.ExportLogsDirectory = directory;
		}

		public void Save()
		{
			UserSettings.Default.Save();
		}
	}
}
