using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Infrastructure.Settings
{
	public interface ISettingsManager
	{
		bool ShouldGetAllLogs { get;  }

		int GetMaxNumberOfLogs();

		void SetMaxNumberOfLogs(int maxNumberOfLogs);

		string GetDefaultLogsDirectory();

		void SetDefaultLogsDirectory(string directory);

		bool GetLoadLogsFromDefaultDirectoryAtStartup();

		void SetLoadLogsFromDefaultDirectoryAtStartup(bool shouldLoad);

		string GetDefaultExportDirectory();

		void SetDefaultExportDirectory(string directory);

		DateIntervalSpanEnum GetDefaultDateInterval();

		void SetDefaultDateInterval(DateIntervalSpanEnum interval);
		
		void Save();
	}
}
