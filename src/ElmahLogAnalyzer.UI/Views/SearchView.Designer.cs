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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._FilterView = new ElmahLogAnalyzer.UI.Views.Partials.SearchFilterView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._resultView = new ElmahLogAnalyzer.UI.Views.Partials.SearchResultView();
			this._detailsView = new ElmahLogAnalyzer.UI.Views.Partials.SearchDetailsView();
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
			this.tableLayoutPanel1.Controls.Add(this._FilterView, 0, 0);
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
			// _FilterView
			// 
			this._FilterView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._FilterView.Location = new System.Drawing.Point(3, 3);
			this._FilterView.Name = "_FilterView";
			this._FilterView.Size = new System.Drawing.Size(1273, 208);
			this._FilterView.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 217);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this._resultView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this._detailsView);
			this.splitContainer1.Size = new System.Drawing.Size(1273, 387);
			this.splitContainer1.SplitterDistance = 239;
			this.splitContainer1.TabIndex = 1;
			// 
			// _resultView
			// 
			this._resultView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._resultView.Location = new System.Drawing.Point(0, 0);
			this._resultView.Name = "_resultView";
			this._resultView.Size = new System.Drawing.Size(239, 387);
			this._resultView.TabIndex = 0;
			// 
			// _detailsView
			// 
			this._detailsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._detailsView.Location = new System.Drawing.Point(0, 0);
			this._detailsView.Name = "_detailsView";
			this._detailsView.Size = new System.Drawing.Size(1030, 387);
			this._detailsView.TabIndex = 0;
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
		private SearchFilterView _FilterView;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private SearchResultView _resultView;
		private SearchDetailsView _detailsView;
	}
}
