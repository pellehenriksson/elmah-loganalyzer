namespace ElmahLogAnalyzer.UI.Views.Partials
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._numberOfResultsLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _resultTreeView
			// 
			this._resultTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._resultTreeView.ImageIndex = 0;
			this._resultTreeView.ImageList = this._treeImageList;
			this._resultTreeView.Location = new System.Drawing.Point(3, 3);
			this._resultTreeView.Name = "_resultTreeView";
			this._resultTreeView.SelectedImageIndex = 0;
			this._resultTreeView.Size = new System.Drawing.Size(211, 288);
			this._resultTreeView.TabIndex = 1;
			this._resultTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ResultTreeViewAfterSelect);
			// 
			// _treeImageList
			// 
			this._treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_treeImageList.ImageStream")));
			this._treeImageList.TransparentColor = System.Drawing.Color.Transparent;
			this._treeImageList.Images.SetKeyName(0, "folder.png");
			this._treeImageList.Images.SetKeyName(1, "bug.png");
			this._treeImageList.Images.SetKeyName(2, "lightbulb.png");
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this._numberOfResultsLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._resultTreeView, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 314);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// _numberOfResultsLabel
			// 
			this._numberOfResultsLabel.AutoSize = true;
			this._numberOfResultsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._numberOfResultsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._numberOfResultsLabel.Location = new System.Drawing.Point(3, 294);
			this._numberOfResultsLabel.Name = "_numberOfResultsLabel";
			this._numberOfResultsLabel.Size = new System.Drawing.Size(211, 20);
			this._numberOfResultsLabel.TabIndex = 3;
			// 
			// SearchResultView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SearchResultView";
			this.Size = new System.Drawing.Size(217, 314);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView _resultTreeView;
		private System.Windows.Forms.ImageList _treeImageList;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label _numberOfResultsLabel;
	}
}
