using Crepido.ElmahOfflineViewer.Core.Presentation;
using Crepido.ElmahOfflineViewer.UI.Forms;
using Crepido.ElmahOfflineViewer.UI.Views;
using Ninject.Modules;

namespace Crepido.ElmahOfflineViewer.UI
{
	public class NinjectUiModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ISearchView>().To<SearchView>().InSingletonScope();
			Bind<IReportView>().To<ReportView>().InSingletonScope();
			Bind<ISettingsView>().To<SettingsForm>();
		}
	}
}
