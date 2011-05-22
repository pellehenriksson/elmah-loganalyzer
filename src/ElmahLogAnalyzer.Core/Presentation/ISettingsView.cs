using System;
using System.Collections.Generic;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface ISettingsView
	{
		event EventHandler OnLoaded;

		event EventHandler OnSave;

		int MaxNumberOfLogs { get; }

		void LoadMaxNumberOfLogOptions(IEnumerable<NameValuePair> options, string selectedOption);
	}
}
