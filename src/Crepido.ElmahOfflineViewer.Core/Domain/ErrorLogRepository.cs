using System;
using System.Collections.Generic;
using System.Linq;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLogRepository : IErrorLogRepository
	{
		private readonly IDataSourceService _datasourceService;
		private readonly List<ErrorLog> _errorLogs = new List<ErrorLog>();
		
		private readonly UniqueStringList _types = new UniqueStringList();
		private readonly UniqueStringList _users = new UniqueStringList();
		private readonly UniqueStringList _sources = new UniqueStringList();
		private readonly UniqueStringList _urls = new UniqueStringList();

		public ErrorLogRepository(IDataSourceService datasourceService)
		{
			_datasourceService = datasourceService;
		}

		public event EventHandler<RepositoryInitializedEventArgs> OnInitialized;

		public string Directory { get; private set; }

		public void Initialize(string directory)
		{
			ClearRepository();
			Directory = directory;
			
			_errorLogs.AddRange(_datasourceService.GetLogs(directory));

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
						where e.Time.Date.IsBetween(filter.Interval)
			            select e;

			if (filter.Type.HasValue())
			{
				query = from e in query
				        where e.Type == filter.Type
				        select e;
			}

			if (filter.Source.HasValue())
			{
				query = from e in query
						where e.Source == filter.Source
						select e;
			}

			if (filter.User.HasValue())
			{
				query = from e in query
						where e.User == filter.User
						select e;
			}

			if (filter.Url.HasValue())
			{
				query = from e in query
						where e.CleanUrl == filter.Url
						select e;
			}

			if (filter.Text.HasValue())
			{
				query = from e in query
						where e.Message.ContainsText(filter.Text) || e.Details.ContainsText(filter.Text)
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
		}
	}
}
