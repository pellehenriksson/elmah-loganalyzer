namespace Crepido.ElmahOfflineViewer.UI
{
	partial class SettingsForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._saveButton = new System.Windows.Forms.Button();
			this._numberOfLogsToLoadComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this._cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _saveButton
			// 
			this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._saveButton.Location = new System.Drawing.Point(284, 145);
			this._saveButton.Name = "_saveButton";
			this._saveButton.Size = new System.Drawing.Size(75, 23);
			this._saveButton.TabIndex = 2;
			this._saveButton.Text = "Save";
			this._saveButton.UseVisualStyleBackColor = true;
			this._saveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// _numberOfLogsToLoadComboBox
			// 
			this._numberOfLogsToLoadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._numberOfLogsToLoadComboBox.FormattingEnabled = true;
			this._numberOfLogsToLoadComboBox.Location = new System.Drawing.Point(155, 12);
			this._numberOfLogsToLoadComboBox.Name = "_numberOfLogsToLoadComboBox";
			this._numberOfLogsToLoadComboBox.Size = new System.Drawing.Size(113, 21);
			this._numberOfLogsToLoadComboBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Max number of logs to load:";
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.Location = new System.Drawing.Point(365, 145);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 3;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 180);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._saveButton);
			this.Controls.Add(this._numberOfLogsToLoadComboBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _saveButton;
		private System.Windows.Forms.ComboBox _numberOfLogsToLoadComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _cancelButton;
	}
}