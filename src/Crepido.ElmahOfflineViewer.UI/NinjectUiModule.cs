using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.Core.Presentation;
using Crepido.ElmahOfflineViewer.Core.Presentation.Abstract;
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
			Bind<IErrorLogRepository>().To<ErrorLogRepository>().InSingletonScope();

			Bind<IDataSourceService>().To<DataSourceService>();
			Bind<IErrorLogFileParser>().To<ErrorLogFileParser>();
			Bind<IReportGenerator>().To<ReportGenerator>();
			Bind<SearchPresenter>().To<SearchPresenter>();
			Bind<ReportPresenter>().To<ReportPresenter>();
		}
	}
}
