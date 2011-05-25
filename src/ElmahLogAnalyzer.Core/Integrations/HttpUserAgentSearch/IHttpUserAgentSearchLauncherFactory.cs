namespace ElmahLogAnalyzer.Core.Integrations.HttpUserAgentSearch
{
	public interface IHttpUserAgentSearchLauncherFactory
	{
		IHttpUserAgentSearchLauncher Create(string searchLauncher);
	}
}
