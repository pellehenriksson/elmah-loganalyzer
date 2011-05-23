using System.Collections.Generic;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.UI.Controls
{
	public partial class NameValuePairListView : UserControl
	{
		public NameValuePairListView()
		{
			InitializeComponent();
		}

		public void LoadValues(IEnumerable<NameValuePair> values)
		{
			_itemsListView.Items.Clear();

			foreach (var value in values)
			{
				var nameNode = _itemsListView.Items.Add(value.Name);
				nameNode.SubItems.Add(new ListViewItem.ListViewSubItem(nameNode, value.Value));

				nameNode.ToolTipText = value.Value;
			}

			_itemsListView.AutoResizeColumns(_itemsListView.Items.Count > 0
										? ColumnHeaderAutoResizeStyle.ColumnContent
										: ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		public void ClearValues()
		{
			_itemsListView.Items.Clear();
		}
		
		private void ContextMenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem.Text == "Copy value")
			{
				var selectedNode = _itemsListView.SelectedItems[0];
				var value = selectedNode.SubItems[1].Text;

				if (!value.HasValue())
				{
					return;
				}

				Clipboard.SetText(value);
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
				_itemsListView.ContextMenuStrip = _contextMenu;
				_contextMenu.Show(_itemsListView, MousePosition);
			}
		}
	}
}
