namespace ElmahLogAnalyzer.UI.Forms
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
			this._maxNumberOfLogsLabel = new System.Windows.Forms.Label();
			this._cancelButton = new System.Windows.Forms.Button();
			this._defaultExportLogsDirectoryLabel = new System.Windows.Forms.Label();
			this._defaultExportLogsDirectoryTextBox = new System.Windows.Forms.TextBox();
			this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._selectDefaultExportLogsDirectoryButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _saveButton
			// 
			this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._saveButton.Location = new System.Drawing.Point(326, 145);
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
			// _maxNumberOfLogsLabel
			// 
			this._maxNumberOfLogsLabel.AutoSize = true;
			this._maxNumberOfLogsLabel.Location = new System.Drawing.Point(11, 12);
			this._maxNumberOfLogsLabel.Name = "_maxNumberOfLogsLabel";
			this._maxNumberOfLogsLabel.Size = new System.Drawing.Size(137, 13);
			this._maxNumberOfLogsLabel.TabIndex = 0;
			this._maxNumberOfLogsLabel.Text = "Max number of logs to load:";
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.Location = new System.Drawing.Point(407, 145);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 3;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// _defaultExportLogsDirectoryLabel
			// 
			this._defaultExportLogsDirectoryLabel.AutoSize = true;
			this._defaultExportLogsDirectoryLabel.Location = new System.Drawing.Point(12, 52);
			this._defaultExportLogsDirectoryLabel.Name = "_defaultExportLogsDirectoryLabel";
			this._defaultExportLogsDirectoryLabel.Size = new System.Drawing.Size(141, 13);
			this._defaultExportLogsDirectoryLabel.TabIndex = 4;
			this._defaultExportLogsDirectoryLabel.Text = "Default export logs directory:";
			// 
			// _defaultExportLogsDirectoryTextBox
			// 
			this._defaultExportLogsDirectoryTextBox.Location = new System.Drawing.Point(155, 52);
			this._defaultExportLogsDirectoryTextBox.Name = "_defaultExportLogsDirectoryTextBox";
			this._defaultExportLogsDirectoryTextBox.Size = new System.Drawing.Size(285, 20);
			this._defaultExportLogsDirectoryTextBox.TabIndex = 5;
			// 
			// _selectDefaultExportLogsDirectoryButton
			// 
			this._selectDefaultExportLogsDirectoryButton.Location = new System.Drawing.Point(447, 48);
			this._selectDefaultExportLogsDirectoryButton.Name = "_selectDefaultExportLogsDirectoryButton";
			this._selectDefaultExportLogsDirectoryButton.Size = new System.Drawing.Size(38, 23);
			this._selectDefaultExportLogsDirectoryButton.TabIndex = 6;
			this._selectDefaultExportLogsDirectoryButton.Text = "...";
			this._selectDefaultExportLogsDirectoryButton.UseVisualStyleBackColor = true;
			this._selectDefaultExportLogsDirectoryButton.Click += new System.EventHandler(this.SelectDefaultExportLogsDirectoryButtonClick);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 180);
			this.Controls.Add(this._selectDefaultExportLogsDirectoryButton);
			this.Controls.Add(this._defaultExportLogsDirectoryTextBox);
			this.Controls.Add(this._defaultExportLogsDirectoryLabel);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._saveButton);
			this.Controls.Add(this._numberOfLogsToLoadComboBox);
			this.Controls.Add(this._maxNumberOfLogsLabel);
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
		private System.Windows.Forms.Label _maxNumberOfLogsLabel;
		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Label _defaultExportLogsDirectoryLabel;
		private System.Windows.Forms.TextBox _defaultExportLogsDirectoryTextBox;
		private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
		private System.Windows.Forms.Button _selectDefaultExportLogsDirectoryButton;
	}
}