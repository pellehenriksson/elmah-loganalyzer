namespace Crepido.ElmahOfflineViewer.UI.Controls
{
	partial class DateIntervalPicker
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
			this._toLabel = new System.Windows.Forms.Label();
			this._fromLabel = new System.Windows.Forms.Label();
			this._endDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this._startDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// _toLabel
			// 
			this._toLabel.AutoSize = true;
			this._toLabel.Location = new System.Drawing.Point(158, 12);
			this._toLabel.Name = "_toLabel";
			this._toLabel.Size = new System.Drawing.Size(23, 13);
			this._toLabel.TabIndex = 2;
			this._toLabel.Text = "To:";
			// 
			// _fromLabel
			// 
			this._fromLabel.AutoSize = true;
			this._fromLabel.Location = new System.Drawing.Point(7, 11);
			this._fromLabel.Name = "_fromLabel";
			this._fromLabel.Size = new System.Drawing.Size(33, 13);
			this._fromLabel.TabIndex = 0;
			this._fromLabel.Text = "From:";
			// 
			// _endDateTimePicker
			// 
			this._endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._endDateTimePicker.Location = new System.Drawing.Point(187, 12);
			this._endDateTimePicker.Name = "_endDateTimePicker";
			this._endDateTimePicker.Size = new System.Drawing.Size(105, 20);
			this._endDateTimePicker.TabIndex = 3;
			// 
			// _startDateTimePicker
			// 
			this._startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._startDateTimePicker.Location = new System.Drawing.Point(46, 11);
			this._startDateTimePicker.Name = "_startDateTimePicker";
			this._startDateTimePicker.Size = new System.Drawing.Size(105, 20);
			this._startDateTimePicker.TabIndex = 1;
			// 
			// DateIntervalView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._toLabel);
			this.Controls.Add(this._fromLabel);
			this.Controls.Add(this._endDateTimePicker);
			this.Controls.Add(this._startDateTimePicker);
			this.Name = "DateIntervalView";
			this.Size = new System.Drawing.Size(300, 37);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _toLabel;
		private System.Windows.Forms.Label _fromLabel;
		private System.Windows.Forms.DateTimePicker _endDateTimePicker;
		private System.Windows.Forms.DateTimePicker _startDateTimePicker;
	}
}
