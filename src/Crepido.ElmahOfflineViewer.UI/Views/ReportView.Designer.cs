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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.selectionView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.ReportSelectionView();
			this.chartView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.ReportChartView();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.selectionView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.chartView, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 609);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// selectionView
			// 
			this.selectionView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectionView.Location = new System.Drawing.Point(3, 3);
			this.selectionView.Name = "selectionView";
			this.selectionView.Size = new System.Drawing.Size(848, 49);
			this.selectionView.TabIndex = 0;
			// 
			// chartView
			// 
			this.chartView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartView.Location = new System.Drawing.Point(3, 58);
			this.chartView.Name = "chartView";
			this.chartView.Size = new System.Drawing.Size(848, 548);
			this.chartView.TabIndex = 1;
			// 
			// ReportView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ReportView";
			this.Size = new System.Drawing.Size(854, 609);
			this.Load += new System.EventHandler(this.ReportViewLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private ReportSelectionView selectionView;
		private ReportChartView chartView;

	}
}
