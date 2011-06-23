using System;
using System.Collections.Generic;
using System.Linq;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class ErrorLogRepository : IErrorLogRepository
	{
		private readonly IErrorLogSource _datasource;
		private readonly List<ErrorLog> _errorLogs = new List<ErrorLog>();
		
		private readonly UniqueStringList _types = new UniqueStringList();
		private readonly UniqueStringList _users = new UniqueStringList(true);
		private readonly UniqueStringList _sources = new UniqueStringList();
		private readonly UniqueStringList _urls = new UniqueStringList();

		public ErrorLogRepository(IErrorLogSource datasource)
		{
			_datasource = datasource;
		}

		public event EventHandler<RepositoryInitializedEventArgs> OnInitialized;

		public string Directory { get; private set; }

		public void Initialize(string directory)
		{
			ClearRepository();
			Directory = directory;
			
			_errorLogs.AddRange(_datasource.GetLogs(directory));

			foreach (var error in _errorLogs)
			{
				_types.Add(error.Type);
				_users.Add(error.User);
				_sources.Add(error.Source);
				_urls.Add(error.CleanUrl);
			}
			
			if (OnInitialized != null)
			{
				OnInitialized(this, new RepositoryInitializedEventArgs(Directory, _errorLogs.Count));
			}
		}
		
		public List<ErrorLog> GetAll()
		{
			return _errorLogs.OrderByDescending(x => x.Time).ToList();
		}

		public List<string> GetTypes()
		{
			return _types.List;
		}

		public List<string> GetSources()
		{
			return _sources.List;
		}

		public List<string> GetUsers()
		{
			return _users.List;
		}

		public List<string> GetUrls()
		{
			return _urls.List;
		}
		
		public IList<ErrorLog> GetWithFilter(SearchErrorLogQuery filter)
		{
			var query = from e in _errorLogs
			        where 
						e.Time.Date.IsBetween(filter.Interval) &&
						filter.Types.Items.InvertedContains(e.Type, filter.Types.IncludeItems) &&
						filter.Sources.Items.InvertedContains(e.Source, filter.Sources.IncludeItems) &&
						filter.Urls.Items.InvertedContains(e.CleanUrl, filter.Urls.IncludeItems) &&
						filter.Users.Items.InvertedContains(e.User, filter.Users.IncludeItems)
			        select e;

			if (filter.Text.HasValue())
			{
				query = from e in query
						where e.Message.ContainsText(filter.Text, true) || e.Details.ContainsText(filter.Text, true)
						select e;
			}

			return query.OrderByDescending(x => x.Time).ToList();
		}
		
		private void ClearRepository()
		{
			_errorLogs.Clear();
			_types.Clear();
			_users.Clear();
			_sources.Clear();
			_urls.Clear();
		}
	}
}
