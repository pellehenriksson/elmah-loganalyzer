namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	partial class SearchResultView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultView));
			this._resultTreeView = new System.Windows.Forms.TreeView();
			this._treeImageList = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// _resultTreeView
			// 
			this._resultTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._resultTreeView.ImageIndex = 0;
			this._resultTreeView.ImageList = this._treeImageList;
			this._resultTreeView.Location = new System.Drawing.Point(0, 0);
			this._resultTreeView.Name = "_resultTreeView";
			this._resultTreeView.SelectedImageIndex = 0;
			this._resultTreeView.Size = new System.Drawing.Size(217, 314);
			this._resultTreeView.TabIndex = 1;
			this._resultTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ResultTreeView_AfterSelect);
			// 
			// _treeImageList
			// 
			this._treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_treeImageList.ImageStream")));
			this._treeImageList.TransparentColor = System.Drawing.Color.Transparent;
			this._treeImageList.Images.SetKeyName(0, "folder.png");
			this._treeImageList.Images.SetKeyName(1, "bug.png");
			this._treeImageList.Images.SetKeyName(2, "lightbulb.png");
			// 
			// SearchResultView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._resultTreeView);
			this.Name = "SearchResultView";
			this.Size = new System.Drawing.Size(217, 314);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView _resultTreeView;
		private System.Windows.Forms.ImageList _treeImageList;
	}
}
