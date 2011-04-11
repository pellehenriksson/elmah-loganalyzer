using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
			LoadCombobox(_typeComboBox, types);
		}

		public void LoadUsers(IList<string> users)
		{
			LoadCombobox(_usersComboBox, users);
		}
		
		public void LoadSources(IList<string> sources)
		{
			LoadCombobox(_sourceComboBox, sources);
		}

		public void SetTimeInterval(DateTime startTime, DateTime endTime)
		{
			_startDateTimePicker.Value = startTime;
			_endDateTimePicker.Value = endTime;
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
			       		Type = _typeComboBox.SelectedItem.ToString(),
			       		Source = _sourceComboBox.SelectedItem.ToString(),
			       		User = _usersComboBox.SelectedItem.ToString(),
			       		Text = _textTextbox.Text,
			       		StartTime = _startDateTimePicker.Value,
			       		EndTime = _endDateTimePicker.Value
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
