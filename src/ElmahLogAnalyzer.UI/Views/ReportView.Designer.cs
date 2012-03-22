using ElmahLogAnalyzer.UI.Views.Partials;

namespace ElmahLogAnalyzer.UI.Views
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
			this._selectionView = new ElmahLogAnalyzer.UI.Views.Partials.ReportSelectionView();
			this._chartView = new ElmahLogAnalyzer.UI.Views.Partials.ReportChartView();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this._selectionView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._chartView, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 609);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _selectionView
			// 
			this._selectionView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._selectionView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._selectionView.Location = new System.Drawing.Point(3, 3);
			this._selectionView.Name = "_selectionView";
			this._selectionView.Size = new System.Drawing.Size(1049, 82);
			this._selectionView.TabIndex = 0;
			// 
			// _chartView
			// 
			this._chartView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._chartView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._chartView.Location = new System.Drawing.Point(3, 91);
			this._chartView.Name = "_chartView";
			this._chartView.Size = new System.Drawing.Size(1049, 515);
			this._chartView.TabIndex = 1;
			// 
			// ReportView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ReportView";
			this.Size = new System.Drawing.Size(1055, 609);
			this.Load += new System.EventHandler(this.ReportViewLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private ReportSelectionView _selectionView;
		private ReportChartView _chartView;

	}
}
