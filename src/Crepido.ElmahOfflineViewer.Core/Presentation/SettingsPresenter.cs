using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public class SettingsPresenter
	{
		private static readonly List<NameValuePair> MaxNumberOfLogOptions = new List<NameValuePair>
		                                                                    	{
		                                                                    		new NameValuePair("All", "-1"), 
																					new NameValuePair("50", "50"), 
																					new NameValuePair("100", "100"), 
																					new NameValuePair("200", "200"), 
																					new NameValuePair("300", "300"), 
																					new NameValuePair("400", "400"), 
																					new NameValuePair("500", "500")
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
