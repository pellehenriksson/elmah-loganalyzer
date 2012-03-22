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
			this._horizontalSplitContainer = new System.Windows.Forms.SplitContainer();
			this._filterView = new ElmahLogAnalyzer.UI.Views.Partials.SearchFilterView();
			this._verticalSplitContainer = new System.Windows.Forms.SplitContainer();
			this._resultView = new ElmahLogAnalyzer.UI.Views.Partials.SearchResultView();
			this._detailsView = new ElmahLogAnalyzer.UI.Views.Partials.SearchDetailsView();
			((System.ComponentModel.ISupportInitialize)(this._horizontalSplitContainer)).BeginInit();
			this._horizontalSplitContainer.Panel1.SuspendLayout();
			this._horizontalSplitContainer.Panel2.SuspendLayout();
			this._horizontalSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._verticalSplitContainer)).BeginInit();
			this._verticalSplitContainer.Panel1.SuspendLayout();
			this._verticalSplitContainer.Panel2.SuspendLayout();
			this._verticalSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// _horizontalSplitContainer
			// 
			this._horizontalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._horizontalSplitContainer.Location = new System.Drawing.Point(0, 0);
			this._horizontalSplitContainer.Name = "_horizontalSplitContainer";
			this._horizontalSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _horizontalSplitContainer.Panel1
			// 
			this._horizontalSplitContainer.Panel1.Controls.Add(this._filterView);
			// 
			// _horizontalSplitContainer.Panel2
			// 
			this._horizontalSplitContainer.Panel2.Controls.Add(this._verticalSplitContainer);
			this._horizontalSplitContainer.Size = new System.Drawing.Size(991, 782);
			this._horizontalSplitContainer.SplitterDistance = 309;
			this._horizontalSplitContainer.TabIndex = 0;
			// 
			// _filterView
			// 
			this._filterView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._filterView.Location = new System.Drawing.Point(0, 0);
			this._filterView.Name = "_filterView";
			this._filterView.Size = new System.Drawing.Size(991, 309);
			this._filterView.TabIndex = 0;
			// 
			// _verticalSplitContainer
			// 
			this._verticalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._verticalSplitContainer.Location = new System.Drawing.Point(0, 0);
			this._verticalSplitContainer.Name = "_verticalSplitContainer";
			// 
			// _verticalSplitContainer.Panel1
			// 
			this._verticalSplitContainer.Panel1.Controls.Add(this._resultView);
			// 
			// _verticalSplitContainer.Panel2
			// 
			this._verticalSplitContainer.Panel2.Controls.Add(this._detailsView);
			this._verticalSplitContainer.Size = new System.Drawing.Size(991, 469);
			this._verticalSplitContainer.SplitterDistance = 209;
			this._verticalSplitContainer.TabIndex = 0;
			// 
			// _resultView
			// 
			this._resultView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._resultView.Location = new System.Drawing.Point(0, 0);
			this._resultView.Name = "_resultView";
			this._resultView.Size = new System.Drawing.Size(209, 469);
			this._resultView.TabIndex = 0;
			// 
			// _detailsView
			// 
			this._detailsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._detailsView.Location = new System.Drawing.Point(0, 0);
			this._detailsView.Name = "_detailsView";
			this._detailsView.Size = new System.Drawing.Size(778, 469);
			this._detailsView.TabIndex = 0;
			// 
			// SearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._horizontalSplitContainer);
			this.Name = "SearchView";
			this.Size = new System.Drawing.Size(991, 782);
			this.Load += new System.EventHandler(this.SearchViewLoad);
			this._horizontalSplitContainer.Panel1.ResumeLayout(false);
			this._horizontalSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._horizontalSplitContainer)).EndInit();
			this._horizontalSplitContainer.ResumeLayout(false);
			this._verticalSplitContainer.Panel1.ResumeLayout(false);
			this._verticalSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._verticalSplitContainer)).EndInit();
			this._verticalSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer _horizontalSplitContainer;
		private System.Windows.Forms.SplitContainer _verticalSplitContainer;
		private SearchFilterView _filterView;
		private SearchResultView _resultView;
		private SearchDetailsView _detailsView;

	}
}
