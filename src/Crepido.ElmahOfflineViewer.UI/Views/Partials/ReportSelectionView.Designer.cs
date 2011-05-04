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
			this._reportsComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this._showButton = new System.Windows.Forms.Button();
			this._dateIntervalView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.DateIntervalView();
			this.SuspendLayout();
			// 
			// _reportsComboBox
			// 
			this._reportsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._reportsComboBox.FormattingEnabled = true;
			this._reportsComboBox.Location = new System.Drawing.Point(357, 16);
			this._reportsComboBox.Name = "_reportsComboBox";
			this._reportsComboBox.Size = new System.Drawing.Size(383, 21);
			this._reportsComboBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(309, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Report:";
			// 
			// _showButton
			// 
			this._showButton.Location = new System.Drawing.Point(746, 16);
			this._showButton.Name = "_showButton";
			this._showButton.Size = new System.Drawing.Size(75, 23);
			this._showButton.TabIndex = 3;
			this._showButton.Text = "Show";
			this._showButton.UseVisualStyleBackColor = true;
			this._showButton.Click += new System.EventHandler(this.ShowButtonClick);
			// 
			// _dateIntervalView
			// 
			this._dateIntervalView.Location = new System.Drawing.Point(3, 3);
			this._dateIntervalView.Name = "_dateIntervalView";
			this._dateIntervalView.Size = new System.Drawing.Size(291, 66);
			this._dateIntervalView.TabIndex = 0;
			// 
			// ReportSelectionView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._dateIntervalView);
			this.Controls.Add(this._showButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._reportsComboBox);
			this.Name = "ReportSelectionView";
			this.Size = new System.Drawing.Size(828, 49);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _reportsComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _showButton;
		private DateIntervalView _dateIntervalView;
	}
}
