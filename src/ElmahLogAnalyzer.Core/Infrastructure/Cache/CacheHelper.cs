using System;
using System.Runtime.Caching;

namespace ElmahLogAnalyzer.Core.Infrastructure.Cache
{
	public class CacheHelper : ICacheHelper
	{
		private static MemoryCache Cache
		{
			get { return MemoryCache.Default; }
		}
		
		public T Get<T>(string key)
		{
			var dataInCache = Cache.Get(key);
			
			if (dataInCache == null)
			{
				return default(T);
			}

			return (T)dataInCache;
		}

		public void Set<T>(string key, T data)
		{
			Cache.Set(key, data, new CacheItemPolicy { AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddHours(2)) });
		}
	}
}
