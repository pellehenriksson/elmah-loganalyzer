using ElmahLogAnalyzer.Core.Presentation;
using ElmahLogAnalyzer.UI.Views.Partials;

namespace ElmahLogAnalyzer.UI.Views
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
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this._filterView = new ElmahLogAnalyzer.UI.Views.Partials.SearchFilterView();
			this._resultView = new ElmahLogAnalyzer.UI.Views.Partials.SearchResultView();
			this._detailsView = new ElmahLogAnalyzer.UI.Views.Partials.SearchDetailsView();
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
			this.splitContainer1.Panel1.Controls.Add(this._filterView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1279, 607);
			this.splitContainer1.SplitterDistance = 211;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this._resultView);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this._detailsView);
			this.splitContainer2.Size = new System.Drawing.Size(1279, 392);
			this.splitContainer2.SplitterDistance = 271;
			this.splitContainer2.TabIndex = 0;
			// 
			// _filterView
			// 
			this._filterView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._filterView.Location = new System.Drawing.Point(0, 0);
			this._filterView.Name = "_filterView";
			this._filterView.Size = new System.Drawing.Size(1279, 211);
			this._filterView.TabIndex = 0;
			// 
			// _resultView
			// 
			this._resultView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._resultView.Location = new System.Drawing.Point(0, 0);
			this._resultView.Name = "_resultView";
			this._resultView.Size = new System.Drawing.Size(271, 392);
			this._resultView.TabIndex = 0;
			// 
			// _detailsView
			// 
			this._detailsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._detailsView.Location = new System.Drawing.Point(0, 0);
			this._detailsView.Name = "_detailsView";
			this._detailsView.Size = new System.Drawing.Size(1004, 392);
			this._detailsView.TabIndex = 0;
			// 
			// SearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "SearchView";
			this.Size = new System.Drawing.Size(1279, 607);
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
		private SearchFilterView _filterView;
		private SearchResultView _resultView;
		private SearchDetailsView _detailsView;

	}
}
