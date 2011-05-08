using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Crepido.ElmahOfflineViewer.UI.Controls
{
	public partial class SelectorView : UserControl
	{
		private const int ScrollBarWidth = 21;

		public SelectorView()
		{
			InitializeComponent();
			Initialize();
		}
		
		public string Caption
		{
			get { return _itemsListView.Columns[0].Text;  }
			set { _itemsListView.Columns[0].Text = value; }
		}

		public void LoadValues(IEnumerable<string> values)
		{
			_itemsListView.Items.Clear();

			foreach (var value in values)
			{
				var item = _itemsListView.Items.Add(value);
				item.ToolTipText = value;
				item.Checked = true;
			}

			SetItemColumnsWidth();
		}
		
		public List<string> GetValues()
		{
			return (from ListViewItem item in _itemsListView.CheckedItems select item.Text).ToList();
		}

		public bool GetMode()
		{
			return _modeComboBox.SelectedIndex == 0;
		}

		private void Initialize()
		{
			_modeComboBox.Items.Add("Include");
			_modeComboBox.Items.Add("Exclude");
			_modeComboBox.SelectedIndex = 0;
		}

		private void SetItemColumnsWidth()
		{
			_itemsListView.Columns[0].Width = _itemsListView.Width - ScrollBarWidth;
		}

		private void HandleSelection(bool check)
		{
			for (var index = 0; index < _itemsListView.Items.Count; index++)
			{
				_itemsListView.Items[index].Checked = check;
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

		private void ItemsListContextMenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.Text == "Copy value")
			{
				var selectedValue = _itemsListView.SelectedItems[0].Text;
				Clipboard.SetText(selectedValue);
			}
		}

		private void ItemsListViewMouseClick(object sender, MouseEventArgs e)
		{
			if (_itemsListView.Items.Count == 0)
			{
				return;
			}

			if (_itemsListView.SelectedItems.Count == 0)
			{
				return;
			}

			if (e.Button == MouseButtons.Right)
			{
				_itemsListView.ContextMenuStrip = _itemsListContextMenu;
				_itemsListContextMenu.Show(_itemsListView, MousePosition);
			}
		}
	}
}
