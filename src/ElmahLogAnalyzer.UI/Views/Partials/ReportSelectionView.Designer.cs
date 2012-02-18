using ElmahLogAnalyzer.UI.Controls;

namespace ElmahLogAnalyzer.UI.Views.Partials
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
			this._reportsComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this._showButton = new System.Windows.Forms.Button();
			this._dateIntervalPicker = new ElmahLogAnalyzer.UI.Controls.DateIntervalPicker();
			this._numberOfResultsComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _reportsComboBox
			// 
			this._reportsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._reportsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._reportsComboBox.FormattingEnabled = true;
			this._reportsComboBox.Location = new System.Drawing.Point(357, 16);
			this._reportsComboBox.Name = "_reportsComboBox";
			this._reportsComboBox.Size = new System.Drawing.Size(280, 21);
			this._reportsComboBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(309, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Report:";
			// 
			// _showButton
			// 
			this._showButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._showButton.Location = new System.Drawing.Point(893, 16);
			this._showButton.Name = "_showButton";
			this._showButton.Size = new System.Drawing.Size(75, 23);
			this._showButton.TabIndex = 3;
			this._showButton.Text = "Show";
			this._showButton.UseVisualStyleBackColor = true;
			this._showButton.Click += new System.EventHandler(this.ShowButtonClick);
			// 
			// _dateIntervalPicker
			// 
			this._dateIntervalPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._dateIntervalPicker.Location = new System.Drawing.Point(3, 3);
			this._dateIntervalPicker.Name = "_dateIntervalPicker";
			this._dateIntervalPicker.Size = new System.Drawing.Size(291, 66);
			this._dateIntervalPicker.TabIndex = 0;
			// 
			// _numberOfResultsComboBox
			// 
			this._numberOfResultsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._numberOfResultsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._numberOfResultsComboBox.FormattingEnabled = true;
			this._numberOfResultsComboBox.Location = new System.Drawing.Point(757, 18);
			this._numberOfResultsComboBox.Name = "_numberOfResultsComboBox";
			this._numberOfResultsComboBox.Size = new System.Drawing.Size(121, 21);
			this._numberOfResultsComboBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(657, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Number of results:";
			// 
			// ReportSelectionView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this._numberOfResultsComboBox);
			this.Controls.Add(this._dateIntervalPicker);
			this.Controls.Add(this._showButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._reportsComboBox);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ReportSelectionView";
			this.Size = new System.Drawing.Size(981, 49);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _reportsComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _showButton;
		private DateIntervalPicker _dateIntervalPicker;
		private System.Windows.Forms.ComboBox _numberOfResultsComboBox;
		private System.Windows.Forms.Label label2;
	}
}
