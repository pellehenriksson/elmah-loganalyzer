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
			_typesSelector.LoadValues(types);
		}

		public void LoadUsers(IEnumerable<string> users)
		{
			_usersSelector.LoadValues(users);
		}
		
		public void LoadSources(IEnumerable<string> sources)
		{
			_sourcesSelector.LoadValues(sources);
		}

		public void LoadUrls(IEnumerable<string> urls)
		{
			_urlsSelector.LoadValues(urls);
		}

		public void SetDateInterval(DateInterval interval)
		{
			_dateIntervalPicker.SetInterval(interval);
		}
		
		private SearchErrorLogQuery BuildQuery()
		{
			return new SearchErrorLogQuery
			       	{
			       		Types = new SearchErrorLogQueryParameter(_typesSelector.GetMode(), _typesSelector.GetValues()),
						Sources = new SearchErrorLogQueryParameter(_sourcesSelector.GetMode(), _sourcesSelector.GetValues()),
						Users = new SearchErrorLogQueryParameter(_usersSelector.GetMode(), _usersSelector.GetValues()),
						Urls = new SearchErrorLogQueryParameter(_urlsSelector.GetMode(), _urlsSelector.GetValues()),
			       		Text = _textTextbox.Text,
						Interval = _dateIntervalPicker.GetInterval()
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
