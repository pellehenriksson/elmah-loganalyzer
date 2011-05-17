using System;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings;

namespace Crepido.ElmahOfflineViewer.TestHelpers.Fakes
{
	public class FakeSettingsManager : ISettingsManager
	{
		private int _maxNumberOfLogs;

		public FakeSettingsManager()
		{
			SetMaxNumberOfLogs(-1);
		}

		public int GetMaxNumberOfLogs()
		{
			return _maxNumberOfLogs;
		}

		public void SetMaxNumberOfLogs(int maxNumberOfLogs)
		{
			_maxNumberOfLogs = maxNumberOfLogs;
		}

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
