using ElmahLogAnalyzer.Core.Infrastructure.Dependencies;
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
			Bind<ISearchView>().To<SearchView>()
				.InScope(context => DataSourceScopeController.KeepAlive);
			
			Bind<IReportView>().To<ReportView>()
				.InScope(context => DataSourceScopeController.KeepAlive);
			
			Bind<ISettingsView>().To<SettingsForm>();
			Bind<IConnectToWebServerView>().To<ConnectToWebServerForm>();
			Bind<IConnectToSqlServerView>().To<ConnectToSqlServerForm>();
			Bind<IConnectToAccessView>().To<ConnectToAccessForm>();
			Bind<IConnectToSqlServerCompactView>().To<ConnectToSqlServerCompactForm>();
			Bind<IExportView>().To<ExportForm>();
			Bind<WelcomeView>().ToSelf();
			Bind<LoadingView>().ToSelf();
			Bind<AboutForm>().ToSelf();
			Bind<Container>().ToSelf();
		}
	}
}
