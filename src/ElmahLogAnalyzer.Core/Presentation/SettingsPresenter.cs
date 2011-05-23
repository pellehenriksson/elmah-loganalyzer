using System;
using System.Collections.Generic;
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
																					new NameValuePair("500 latest", "500")
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
			View.LoadMaxNumberOfLogOptions(MaxNumberOfLogOptions, _settingsManager.GetMaxNumberOfLogs().ToString());
		}

		private void ViewOnSave(object sender, EventArgs e)
		{
			_settingsManager.SetMaxNumberOfLogs(View.MaxNumberOfLogs);
			_settingsManager.Save();
		}

		private void ViewOnLoaded(object sender, EventArgs e)
		{
			Initialize();
		}
	}
}
