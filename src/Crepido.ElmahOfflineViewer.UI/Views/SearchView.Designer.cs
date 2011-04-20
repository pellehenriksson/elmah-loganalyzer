using Crepido.ElmahOfflineViewer.UI.Views.Partials;

namespace Crepido.ElmahOfflineViewer.UI.Views
{
	partial class SearchView
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.searchFilterView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SearchFilterView();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.searchResultTreeView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SearchResultView();
			this.searchDetailsView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SearchErrorDetailsView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.searchFilterView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(881, 607);
			this.splitContainer1.SplitterDistance = 197;
			this.splitContainer1.TabIndex = 0;
			// 
			// searchFilterView
			// 
			this.searchFilterView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchFilterView.Location = new System.Drawing.Point(0, 0);
			this.searchFilterView.Name = "searchFilterView";
			this.searchFilterView.Size = new System.Drawing.Size(881, 197);
			this.searchFilterView.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.searchResultTreeView);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.searchDetailsView);
			this.splitContainer2.Size = new System.Drawing.Size(881, 406);
			this.splitContainer2.SplitterDistance = 221;
			this.splitContainer2.TabIndex = 0;
			// 
			// searchResultTreeView
			// 
			this.searchResultTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchResultTreeView.Location = new System.Drawing.Point(0, 0);
			this.searchResultTreeView.Name = "searchResultTreeView";
			this.searchResultTreeView.Size = new System.Drawing.Size(221, 406);
			this.searchResultTreeView.TabIndex = 0;
			// 
			// searchDetailsView
			// 
			this.searchDetailsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchDetailsView.Location = new System.Drawing.Point(0, 0);
			this.searchDetailsView.Name = "searchDetailsView";
			this.searchDetailsView.Size = new System.Drawing.Size(656, 406);
			this.searchDetailsView.TabIndex = 0;
			// 
			// SearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "SearchView";
			this.Size = new System.Drawing.Size(881, 607);
			this.Load += new System.EventHandler(this.SearchViewLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private SearchFilterView searchFilterView;
		private SearchResultView searchResultTreeView;
		private SearchErrorDetailsView searchDetailsView;
	}
}
