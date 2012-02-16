using System;
using Ninject;
using Ninject.Parameters;

namespace ElmahLogAnalyzer.Core.Infrastructure.Dependencies
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

		public static T ResolveWithConstructorArguments<T>(params IParameter[] parameters)
		{
			return Kernel.Get<T>(parameters);
		}
	}
}
