using System;
using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain.Abstract
{
	public interface IErrorLogRepository
	{
		event EventHandler<RepositoryInitializedEventArgs> OnInitialized; 

		string Directory { get; }
		
		void Initialize(string directory);
		
		List<ErrorLog> GetAll();
		
		IList<ErrorLog> GetWithFilter(SearchErrorLogQuery filter);
		
		List<string> GetTypes();
		
		List<string> GetSources();
		
		List<string> GetUsers();

		List<string> GetUrls();
	}
}
