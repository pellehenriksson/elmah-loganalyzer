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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.searchFilterView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SearchFilterView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.searchResultView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SearchResultView();
			this.searchDetailsView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SearchErrorDetailsView();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.searchFilterView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1279, 607);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// searchFilterView
			// 
			this.searchFilterView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchFilterView.Location = new System.Drawing.Point(3, 3);
			this.searchFilterView.Name = "searchFilterView";
			this.searchFilterView.Size = new System.Drawing.Size(1273, 208);
			this.searchFilterView.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 217);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.searchResultView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.searchDetailsView);
			this.splitContainer1.Size = new System.Drawing.Size(1273, 387);
			this.splitContainer1.SplitterDistance = 239;
			this.splitContainer1.TabIndex = 1;
			// 
			// searchResultView
			// 
			this.searchResultView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchResultView.Location = new System.Drawing.Point(0, 0);
			this.searchResultView.Name = "searchResultView";
			this.searchResultView.Size = new System.Drawing.Size(239, 387);
			this.searchResultView.TabIndex = 0;
			// 
			// searchDetailsView
			// 
			this.searchDetailsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchDetailsView.Location = new System.Drawing.Point(0, 0);
			this.searchDetailsView.Name = "searchDetailsView";
			this.searchDetailsView.Size = new System.Drawing.Size(1030, 387);
			this.searchDetailsView.TabIndex = 0;
			// 
			// SearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SearchView";
			this.Size = new System.Drawing.Size(1279, 607);
			this.Load += new System.EventHandler(this.SearchViewLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private SearchFilterView searchFilterView;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private SearchResultView searchResultView;
		private SearchErrorDetailsView searchDetailsView;

	}
}
