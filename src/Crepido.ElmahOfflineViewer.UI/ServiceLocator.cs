using System;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Dependencies;
using Ninject;
using Ninject.Modules;

namespace Crepido.ElmahOfflineViewer.UI
{
	public static class ServiceLocator
	{
		private static readonly IKernel Kernel = new StandardKernel();

		static ServiceLocator()
		{
			// Kernel.Load(new INinjectModule[] { new NinjectUiModule(), new NinjectCoreModule() });
			Kernel.Load(AppDomain.CurrentDomain.GetAssemblies());
		}

		public static T Resolve<T>()
		{
			return Kernel.Get<T>();
		}
	}
}
