using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;

namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	public partial class SearchFilterView : UserControl
	{
		public SearchFilterView()
		{
			InitializeComponent();
		}

		public event EventHandler<ErrorLogSearchEventArgs> OnFilterApplied;
		
		public void LoadTypes(IEnumerable<string> types)
		{
			_typeSelectorView.LoadValues(types);
		}

		public void LoadUsers(IEnumerable<string> users)
		{
			_usersSelectorView.LoadValues(users);
		}
		
		public void LoadSources(IEnumerable<string> sources)
		{
			_sourcesSelectorView.LoadValues(sources);
		}

		public void LoadUrls(IEnumerable<string> urls)
		{
			_urlsSelectorView.LoadValues(urls);
		}

		public void SetDateInterval(DateInterval interval)
		{
			_dateIntervalView.SetInterval(interval);
		}
		
		private SearchErrorLogQuery BuildQuery()
		{
			return new SearchErrorLogQuery
			       	{
			       		Types = new SearchErrorLogQueryParameter(_typeSelectorView.GetMode(), _typeSelectorView.GetValues()),
						Sources = new SearchErrorLogQueryParameter(_sourcesSelectorView.GetMode(), _sourcesSelectorView.GetValues()),
						Users = new SearchErrorLogQueryParameter(_usersSelectorView.GetMode(), _usersSelectorView.GetValues()),
						Urls = new SearchErrorLogQueryParameter(_urlsSelectorView.GetMode(), _urlsSelectorView.GetValues()),
			       		Text = _textTextbox.Text,
						Interval = _dateIntervalView.GetInterval()
			       	};
		}
		
		private void SearchButtonClick(object sender, EventArgs e)
		{
			if (OnFilterApplied == null)
			{
				return;
			}

			var query = BuildQuery();
			OnFilterApplied(this, new ErrorLogSearchEventArgs(query));
		}
	}
}
