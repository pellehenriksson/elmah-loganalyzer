namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	partial class ReportSelectionView
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
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._endDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this._startDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this._reportsComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this._showButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(167, 17);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "To:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "From:";
			// 
			// _endDateTimePicker
			// 
			this._endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._endDateTimePicker.Location = new System.Drawing.Point(196, 17);
			this._endDateTimePicker.Name = "_endDateTimePicker";
			this._endDateTimePicker.Size = new System.Drawing.Size(105, 20);
			this._endDateTimePicker.TabIndex = 3;
			// 
			// _startDateTimePicker
			// 
			this._startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this._startDateTimePicker.Location = new System.Drawing.Point(55, 16);
			this._startDateTimePicker.Name = "_startDateTimePicker";
			this._startDateTimePicker.Size = new System.Drawing.Size(105, 20);
			this._startDateTimePicker.TabIndex = 1;
			// 
			// _reportsComboBox
			// 
			this._reportsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._reportsComboBox.FormattingEnabled = true;
			this._reportsComboBox.Location = new System.Drawing.Point(371, 16);
			this._reportsComboBox.Name = "_reportsComboBox";
			this._reportsComboBox.Size = new System.Drawing.Size(383, 21);
			this._reportsComboBox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(323, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Report:";
			// 
			// _showButton
			// 
			this._showButton.Location = new System.Drawing.Point(770, 17);
			this._showButton.Name = "_showButton";
			this._showButton.Size = new System.Drawing.Size(75, 23);
			this._showButton.TabIndex = 6;
			this._showButton.Text = "Show";
			this._showButton.UseVisualStyleBackColor = true;
			this._showButton.Click += new System.EventHandler(this.ShowButtonClick);
			// 
			// ReportSelectionView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._showButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._reportsComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._endDateTimePicker);
			this.Controls.Add(this._startDateTimePicker);
			this.Name = "ReportSelectionView";
			this.Size = new System.Drawing.Size(870, 66);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker _endDateTimePicker;
		private System.Windows.Forms.DateTimePicker _startDateTimePicker;
		private System.Windows.Forms.ComboBox _reportsComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _showButton;
	}
}
