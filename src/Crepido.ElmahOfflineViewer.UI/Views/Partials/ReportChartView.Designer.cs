namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	partial class ReportChartView
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			this._chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this._chart)).BeginInit();
			this.SuspendLayout();
			// 
			// _chart
			// 
			chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Angle = -90;
			chartArea1.AxisX.LabelStyle.Interval = 0D;
			chartArea1.Name = "ChartArea1";
			this._chart.ChartAreas.Add(chartArea1);
			this._chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this._chart.Location = new System.Drawing.Point(0, 0);
			this._chart.Name = "_chart";
			this._chart.Size = new System.Drawing.Size(671, 451);
			this._chart.TabIndex = 0;
			this._chart.Text = "chart1";
			// 
			// ReportChartPartialView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._chart);
			this.Name = "ReportChartView";
			this.Size = new System.Drawing.Size(671, 451);
			((System.ComponentModel.ISupportInitialize)(this._chart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart _chart;


	}
}
