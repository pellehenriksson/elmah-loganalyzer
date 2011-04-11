using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Presentation;

namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	public partial class SearchResultView : UserControl
	{
		public SearchResultView()
		{
			InitializeComponent();
		}

		public event EventHandler<ErrorLogSelectedEventArgs> OnErrorLogSelected;

		public void LoadTree(IList<ErrorLog> errorLogs)
		{
			Clear();

			if (errorLogs.Count == 0)
			{
				CreateNoResultsNode();
				return;
			}

			foreach (var error in errorLogs)
			{
				var currentDate = error.Time.Date.ToShortDateString();
				var dateNode = GetDateFolderNode(currentDate) ?? CreateDateFolderNode(currentDate);
				CreateErrorLogNode(dateNode, error);
			}
		}
		
		public void Clear()
		{
			_resultTreeView.Nodes.Clear();
		}

		private TreeNode GetDateFolderNode(string date)
		{
			return _resultTreeView.Nodes.ContainsKey(date) ? _resultTreeView.Nodes[date] : null;
		}

		private TreeNode CreateDateFolderNode(string date)
		{
			var node = _resultTreeView.Nodes.Add(date, date);
			node.ImageIndex = 0;
			node.SelectedImageIndex = 0;

			return node;
		}

		private void CreateErrorLogNode(TreeNode dateFolderNode, ErrorLog errorLog)
		{
			var node = dateFolderNode.Nodes.Add(errorLog.Time.ToString());
			node.Tag = errorLog;
			node.ImageIndex = 1;
			node.SelectedImageIndex = 1;
		}
		
		private void CreateNoResultsNode()
		{
			var node = _resultTreeView.Nodes.Add("No error logs found");
			node.ImageIndex = 2;
			node.SelectedImageIndex = 2;
		}
		
		private void ResultTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var errorLog = e.Node.Tag as ErrorLog;
			if (errorLog == null)
			{
				return;
			}

			if (OnErrorLogSelected != null)
			{
				OnErrorLogSelected(this, new ErrorLogSelectedEventArgs(errorLog));
			}
		}
	}
}
