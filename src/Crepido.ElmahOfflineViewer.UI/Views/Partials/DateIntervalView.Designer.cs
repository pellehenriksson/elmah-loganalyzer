namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	partial class DateIntervalView
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
			this.toLabel = new System.Windows.Forms.Label();
			this.fromLabel = new System.Windows.Forms.Label();
			this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// toLabel
			// 
			this.toLabel.AutoSize = true;
			this.toLabel.Location = new System.Drawing.Point(152, 4);
			this.toLabel.Name = "toLabel";
			this.toLabel.Size = new System.Drawing.Size(23, 13);
			this.toLabel.TabIndex = 6;
			this.toLabel.Text = "To:";
			// 
			// fromLabel
			// 
			this.fromLabel.AutoSize = true;
			this.fromLabel.Location = new System.Drawing.Point(1, 3);
			this.fromLabel.Name = "fromLabel";
			this.fromLabel.Size = new System.Drawing.Size(33, 13);
			this.fromLabel.TabIndex = 4;
			this.fromLabel.Text = "From:";
			// 
			// endDateTimePicker
			// 
			this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.endDateTimePicker.Location = new System.Drawing.Point(181, 4);
			this.endDateTimePicker.Name = "endDateTimePicker";
			this.endDateTimePicker.Size = new System.Drawing.Size(105, 20);
			this.endDateTimePicker.TabIndex = 7;
			// 
			// startDateTimePicker
			// 
			this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.startDateTimePicker.Location = new System.Drawing.Point(40, 3);
			this.startDateTimePicker.Name = "startDateTimePicker";
			this.startDateTimePicker.Size = new System.Drawing.Size(105, 20);
			this.startDateTimePicker.TabIndex = 5;
			// 
			// DateIntervalView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toLabel);
			this.Controls.Add(this.fromLabel);
			this.Controls.Add(this.endDateTimePicker);
			this.Controls.Add(this.startDateTimePicker);
			this.Name = "DateIntervalView";
			this.Size = new System.Drawing.Size(291, 25);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label toLabel;
		private System.Windows.Forms.Label fromLabel;
		private System.Windows.Forms.DateTimePicker endDateTimePicker;
		private System.Windows.Forms.DateTimePicker startDateTimePicker;
	}
}
