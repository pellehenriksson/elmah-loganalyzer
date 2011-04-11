using Crepido.ElmahOfflineViewer.UI.Views.Partials;

namespace Crepido.ElmahOfflineViewer.UI.Views
{
	partial class ReportView
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
			this._selectionView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.ReportSelectionView();
			this._chartView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.ReportChartView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this._selectionView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this._chartView);
			this.splitContainer1.Size = new System.Drawing.Size(854, 609);
			this.splitContainer1.SplitterDistance = 51;
			this.splitContainer1.TabIndex = 0;
			// 
			// _selectionView
			// 
			this._selectionView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._selectionView.Location = new System.Drawing.Point(0, 0);
			this._selectionView.Name = "_selectionView";
			this._selectionView.Size = new System.Drawing.Size(854, 51);
			this._selectionView.TabIndex = 0;
			// 
			// _chartView
			// 
			this._chartView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._chartView.Location = new System.Drawing.Point(0, 0);
			this._chartView.Name = "_chartView";
			this._chartView.Size = new System.Drawing.Size(854, 554);
			this._chartView.TabIndex = 0;
			// 
			// ReportView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "ReportView";
			this.Size = new System.Drawing.Size(854, 609);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private ReportSelectionView _selectionView;
		private ReportChartView _chartView;
	}
}
