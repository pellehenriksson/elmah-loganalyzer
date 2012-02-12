using System;
using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Domain
{
	public interface INewErrorLogRepository
	{
		event EventHandler<RepositoryInitializedEventArgs> OnInitialized;

		string Directory { get; }

		void Initialize();

		List<ErrorLog> GetAll();

		IList<ErrorLog> GetWithFilter(SearchErrorLogQuery filter);

		List<string> GetTypes();

		List<string> GetSources();

		List<string> GetUsers();

		List<string> GetUrls();
	}
}
