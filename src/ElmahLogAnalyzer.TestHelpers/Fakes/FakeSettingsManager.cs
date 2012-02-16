using System;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeSettingsManager : ISettingsManager
	{
		private int _maxNumberOfLogs;
		private DateIntervalSpans _defaultDateInterval;
		private string _defaultExportDirectory;
		private string _defaultLogsDirectory;
		private bool _loadLogsFromDefaultDirectoryAtStartup;

		public FakeSettingsManager()
		{
			SetMaxNumberOfLogs(-1);
		}

		public bool ShouldGetAllLogs
		{
			get { return GetMaxNumberOfLogs() == -1;  }
		}

		public int GetMaxNumberOfLogs()
		{
			return _maxNumberOfLogs;
		}

		public void SetMaxNumberOfLogs(int maxNumberOfLogs)
		{
			_maxNumberOfLogs = maxNumberOfLogs;
		}

		public string GetDefaultLogsDirectory()
		{
			return _defaultLogsDirectory;
		}

		public void SetDefaultLogsDirectory(string directory)
		{
			_defaultLogsDirectory = directory;
		}

		public bool GetLoadLogsFromDefaultDirectoryAtStartup()
		{
			return _loadLogsFromDefaultDirectoryAtStartup;
		}

		public void SetLoadLogsFromDefaultDirectoryAtStartup(bool shouldLoad)
		{
			_loadLogsFromDefaultDirectoryAtStartup = shouldLoad;
		}

		public string GetDefaultExportDirectory()
		{
			return _defaultExportDirectory;
		}

		public void SetDefaultExportDirectory(string directory)
		{
			_defaultExportDirectory = directory;
		}

		public DateIntervalSpans GetDefaultDateInterval()
		{
			return _defaultDateInterval;
		}

		public void SetDefaultDateInterval(DateIntervalSpans interval)
		{
			_defaultDateInterval = interval;
		}

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
