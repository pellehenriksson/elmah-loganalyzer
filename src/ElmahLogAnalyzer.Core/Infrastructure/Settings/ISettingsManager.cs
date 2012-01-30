namespace ElmahLogAnalyzer.Core.Infrastructure.Settings
{
	public interface ISettingsManager
	{
		bool ShouldGetAllLogs { get;  }

		int GetMaxNumberOfLogs();

		void SetMaxNumberOfLogs(int maxNumberOfLogs);

		string GetDefaultExportLogsDirectory();

		void SetDefaultExportLogsDirectory(string directory);

		void Save();
	}
}
