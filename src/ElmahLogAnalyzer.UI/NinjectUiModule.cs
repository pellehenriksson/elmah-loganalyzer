using ElmahLogAnalyzer.Core.Presentation;
using ElmahLogAnalyzer.UI.Forms;
using ElmahLogAnalyzer.UI.Views;
using Ninject.Modules;

namespace ElmahLogAnalyzer.UI
{
	public class NinjectUiModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ISearchView>().To<SearchView>().InSingletonScope();
			Bind<IReportView>().To<ReportView>().InSingletonScope();
			Bind<ISettingsView>().To<SettingsForm>();
			Bind<IConnectToWebServerView>().To<ConnectToWebServerForm>();
			Bind<IExportView>().To<ExportForm>();
		}
	}
}
