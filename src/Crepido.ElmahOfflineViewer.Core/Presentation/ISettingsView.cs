using System;
using System.Collections.Generic;
using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.Core.Presentation
{
	public interface ISettingsView
	{
		event EventHandler OnLoaded;

		event EventHandler OnSave;

		int MaxNumberOfLogs { get; }

		void LoadMaxNumberOfLogOptions(IEnumerable<NameValuePair> options, string selectedOption);
	}
}
