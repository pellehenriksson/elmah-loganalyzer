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
			Bind<ISearchView>().To<SearchView>();
			Bind<IReportView>().To<ReportView>();
			Bind<ISettingsView>().To<SettingsForm>();
			Bind<IConnectToWebServerView>().To<ConnectToWebServerForm>();
			Bind<IConnectToDatabaseView>().To<ConnectToDatabaseForm>();
			Bind<IExportView>().To<ExportForm>();
			Bind<WelcomeView>().ToSelf();
			Bind<LoadingView>().ToSelf();
			Bind<AboutForm>().ToSelf();
			Bind<Container>().ToSelf();
		}
	}
}
