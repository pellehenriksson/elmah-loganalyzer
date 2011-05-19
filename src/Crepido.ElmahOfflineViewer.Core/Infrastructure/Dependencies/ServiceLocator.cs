using System;
using Ninject;

namespace Crepido.ElmahOfflineViewer.Core.Infrastructure.Dependencies
{
	public static class ServiceLocator
	{
		private static readonly IKernel Kernel = new StandardKernel();

		static ServiceLocator()
		{
			Kernel.Load(AppDomain.CurrentDomain.GetAssemblies());
		}

		public static T Resolve<T>()
		{
			return Kernel.Get<T>();
		}
	}
}
