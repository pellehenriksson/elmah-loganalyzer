using System.Reflection;
using Ninject;

namespace Crepido.ElmahOfflineViewer.UI
{
	public static class ServiceLocator
	{
		private static readonly IKernel Kernel = new StandardKernel();

		static ServiceLocator()
		{
			Kernel.Load(Assembly.GetExecutingAssembly());
		}

		public static T Resolve<T>()
		{
			return Kernel.Get<T>();
		}
	}
}
