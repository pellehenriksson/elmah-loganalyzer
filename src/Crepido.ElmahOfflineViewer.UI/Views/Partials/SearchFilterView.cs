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
		
		public void LoadTypes(IList<string> types)
		{
			LoadCombobox(typeComboBox, types);
		}

		public void LoadUsers(IList<string> users)
		{
			LoadCombobox(usersComboBox, users);
		}
		
		public void LoadSources(IList<string> sources)
		{
			LoadCombobox(sourceComboBox, sources);
		}

		public void LoadUrls(IList<string> urls)
		{
			LoadCombobox(urlsComboBox, urls);
		}

		public void SetDateInterval(DateInterval interval)
		{
			dateIntervalView.SetInterval(interval);
		}

		private void LoadCombobox(ComboBox comboBox, IEnumerable<string> values)
		{
			comboBox.Items.Clear();
			comboBox.Items.Add(string.Empty);

			foreach (var value in values)
			{
				comboBox.Items.Add(value);
			}

			comboBox.SelectedIndex = 0;
		}
		
		private SearchErrorLogQuery BuildQuery()
		{
			return new SearchErrorLogQuery
			       	{
			       		Type = typeComboBox.SelectedItem.ToString(),
			       		Source = sourceComboBox.SelectedItem.ToString(),
			       		User = usersComboBox.SelectedItem.ToString(),
			       		Text = textTextbox.Text,
						Url = urlsComboBox.SelectedItem.ToString(),
						Interval = dateIntervalView.GetInterval()
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
