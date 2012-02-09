using System;
using System.Collections.Generic;
using System.Globalization;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class SettingsPresenter
	{
		private static readonly List<NameValuePair> MaxNumberOfLogOptions = new List<NameValuePair>
		{
			new NameValuePair("All logs", "-1"), 
			new NameValuePair("50 latest", "50"), 
			new NameValuePair("100 latest", "100"), 
			new NameValuePair("200 latest", "200"), 
			new NameValuePair("300 latest", "300"), 
			new NameValuePair("400 latest", "400"), 
			new NameValuePair("500 latest", "500"),
			new NameValuePair("750 latest", "750"),
			new NameValuePair("1000 latest", "1000")
		};

		private static readonly List<NameValuePair> DefaultDateIntervalOptions = new List<NameValuePair>
		{
			new NameValuePair("Start a week back in time", ((int)DateIntervalSpanEnum.Week).ToString(CultureInfo.InvariantCulture)),
			new NameValuePair("Start a month back in time", ((int)DateIntervalSpanEnum.Month).ToString(CultureInfo.InvariantCulture)),
			new NameValuePair("Start a year back in time", ((int)DateIntervalSpanEnum.Year).ToString(CultureInfo.InvariantCulture)),
		};

		private readonly ISettingsManager _settingsManager;

		public SettingsPresenter(ISettingsView view, ISettingsManager settingsManager)
		{
			View = view;
			_settingsManager = settingsManager;
			
			RegisterEvents();
		}

		public ISettingsView View { get; private set; }
		
		private void RegisterEvents()
		{
			View.OnLoaded += ViewOnLoaded;
			View.OnSave += ViewOnSave;
		}

		private void Initialize()
		{
			View.LoadDefaultDateIntervalOptions(DefaultDateIntervalOptions, _settingsManager.GetDefaultDateInterval());
			View.LoadMaxNumberOfLogOptions(MaxNumberOfLogOptions, _settingsManager.GetMaxNumberOfLogs().ToString(CultureInfo.InvariantCulture));
			View.DefaultLogsDirectory = _settingsManager.GetDefaultLogsDirectory();
			View.LoadLogsFromDefaultDirectoryAtStartup = _settingsManager.GetLoadLogsFromDefaultDirectoryAtStartup();
			View.DefaultExportDirectory = _settingsManager.GetDefaultExportDirectory();
		}

		private void ViewOnSave(object sender, EventArgs e)
		{
			_settingsManager.SetDefaultDateInterval(View.DefaultDateInterval);
			_settingsManager.SetMaxNumberOfLogs(View.MaxNumberOfLogs);
			_settingsManager.SetDefaultLogsDirectory(View.DefaultLogsDirectory);
			_settingsManager.SetLoadLogsFromDefaultDirectoryAtStartup(View.LoadLogsFromDefaultDirectoryAtStartup);
			_settingsManager.SetDefaultExportDirectory(View.DefaultExportDirectory);
			_settingsManager.Save();
		}

		private void ViewOnLoaded(object sender, EventArgs e)
		{
			Initialize();
		}
	}
}
