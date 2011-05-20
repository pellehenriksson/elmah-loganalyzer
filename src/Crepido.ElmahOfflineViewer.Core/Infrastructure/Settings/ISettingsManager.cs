namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings
{
	public interface ISettingsManager
	{
		bool ShouldGetAllLogs { get;  }

		int GetMaxNumberOfLogs();

		void SetMaxNumberOfLogs(int maxNumberOfLogs);

		void Save();
	}
}
