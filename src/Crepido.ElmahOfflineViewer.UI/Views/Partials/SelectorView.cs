using System.Collections.Generic;
using System.Windows.Forms;

namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	public partial class SelectorView : UserControl
	{
		public SelectorView()
		{
			InitializeComponent();
			Initialize();
		}
		
		public void LoadValues(IEnumerable<string> values)
		{
			itemsListBox.Items.Clear();
			foreach (var value in values)
			{
				itemsListBox.Items.Add(value, CheckState.Checked);
			}
		}

		public List<string> GetValues()
		{
			var result = new List<string>();
			{
				for (var index = 0; index < itemsListBox.Items.Count; index++)
				{
					if (itemsListBox.GetItemChecked(index))
					{
						result.Add(itemsListBox.Items[index].ToString());
					}
				}
			}

			return result;
		}

		public bool GetMode()
		{
			return modeComboBox.SelectedIndex == 0;
		}

		private void Initialize()
		{
			itemsListBox.CheckOnClick = true;

			modeComboBox.Items.Add("Include");
			modeComboBox.Items.Add("Exclude");
			modeComboBox.SelectedIndex = 0;
		}

		private void HandleSelection(bool check)
		{
			for (var index = 0; index < itemsListBox.Items.Count; index++)
			{
				itemsListBox.SetItemChecked(index, check);
			}
		}

		private void AllButtonClick(object sender, System.EventArgs e)
		{
			HandleSelection(true);
		}

		private void NoneButtonClick(object sender, System.EventArgs e)
		{
			HandleSelection(false);
		}
	}
}
