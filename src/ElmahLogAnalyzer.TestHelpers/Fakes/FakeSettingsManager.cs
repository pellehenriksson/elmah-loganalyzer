using System;
using ElmahLogAnalyzer.Core.Infrastructure.Settings;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeSettingsManager : ISettingsManager
	{
		private int _maxNumberOfLogs;

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

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
