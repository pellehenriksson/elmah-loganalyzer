using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface ISettingsView
	{
		event EventHandler OnLoaded;

		event EventHandler OnSave;

		string DefaultLogsDirectory { get; set; }

		bool LoadLogsFromDefaultDirectoryAtStartup { get; set; }

		string DefaultExportDirectory { get; set; }

		int MaxNumberOfLogs { get; }

		DateIntervalSpanEnum DefaultDateInterval { get; }

		void LoadMaxNumberOfLogOptions(IEnumerable<NameValuePair> options, string selectedOption);

		void LoadDefaultDateIntervalOptions(IEnumerable<NameValuePair> options, DateIntervalSpanEnum selectedOption);
	}
}
