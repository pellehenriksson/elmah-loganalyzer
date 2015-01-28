using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Views.Partials
{
	public partial class SearchFilterView : UserControl
	{
		public SearchFilterView()
		{
			InitializeComponent();
		}

		public event EventHandler<ErrorLogSearchEventArgs> OnFilterApplied;

		public void LoadApplications(IEnumerable<string> applications)
		{
			_applicationsComboBox.DataSource = applications;
			
			if (_applicationsComboBox.Items.Count > 0)
			{
				_applicationsComboBox.SelectedIndex = 0;
			}
		}

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
				Application = this.GetSelectedApplication(),
			    Types = new SearchErrorLogQueryParameter(_typesSelector.GetMode(), _typesSelector.GetValues()),
				Sources = new SearchErrorLogQueryParameter(_sourcesSelector.GetMode(), _sourcesSelector.GetValues()),
				Users = new SearchErrorLogQueryParameter(_usersSelector.GetMode(), _usersSelector.GetValues()),
				Urls = new SearchErrorLogQueryParameter(_urlsSelector.GetMode(), _urlsSelector.GetValues()),
			    Text = _textTextbox.Text,
				Interval = _dateIntervalPicker.GetInterval()
			};
		}

	    private string GetSelectedApplication()
	    {
	        if (_applicationsComboBox.SelectedItem == null)
	        {
	            return string.Empty;
	        }

	        return _applicationsComboBox.SelectedItem.ToString();
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
