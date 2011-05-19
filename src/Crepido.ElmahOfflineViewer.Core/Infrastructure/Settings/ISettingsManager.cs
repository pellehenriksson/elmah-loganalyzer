namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Settings
{
	public interface ISettingsManager
	{
		int GetMaxNumberOfLogs();

		void SetMaxNumberOfLogs(int maxNumberOfLogs);

		void Save();
	}
}
