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
			this._cancelButton = new System.Windows.Forms.Button();
			this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._exportGroupBox = new System.Windows.Forms.GroupBox();
			this._selectDefaultExportDirectoryButton = new System.Windows.Forms.Button();
			this._defaultExportDirectoryTextBox = new System.Windows.Forms.TextBox();
			this._defaultExportDirectoryLabel = new System.Windows.Forms.Label();
			this._startupGroupBox = new System.Windows.Forms.GroupBox();
			this._defaultDateIntervalFilterComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this._loadLogsFromDefaultDirectoryAtStartupCheckBox = new System.Windows.Forms.CheckBox();
			this._selectDefaultLogsDirectoryButton = new System.Windows.Forms.Button();
			this._defaultLogsDirectoryTextBox = new System.Windows.Forms.TextBox();
			this._defaultLogsDirectoryLabel = new System.Windows.Forms.Label();
			this._numberOfLogsToLoadComboBox = new System.Windows.Forms.ComboBox();
			this._maxNumberOfLogsLabel = new System.Windows.Forms.Label();
			this._exportGroupBox.SuspendLayout();
			this._startupGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _saveButton
			// 
			this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._saveButton.Location = new System.Drawing.Point(348, 270);
			this._saveButton.Name = "_saveButton";
			this._saveButton.Size = new System.Drawing.Size(75, 23);
			this._saveButton.TabIndex = 0;
			this._saveButton.Text = "Save";
			this._saveButton.UseVisualStyleBackColor = true;
			this._saveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.Location = new System.Drawing.Point(429, 270);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 1;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// _exportGroupBox
			// 
			this._exportGroupBox.Controls.Add(this._selectDefaultExportDirectoryButton);
			this._exportGroupBox.Controls.Add(this._defaultExportDirectoryTextBox);
			this._exportGroupBox.Controls.Add(this._defaultExportDirectoryLabel);
			this._exportGroupBox.Location = new System.Drawing.Point(10, 181);
			this._exportGroupBox.Name = "_exportGroupBox";
			this._exportGroupBox.Size = new System.Drawing.Size(491, 75);
			this._exportGroupBox.TabIndex = 1;
			this._exportGroupBox.TabStop = false;
			this._exportGroupBox.Text = "Export";
			// 
			// _selectDefaultExportDirectoryButton
			// 
			this._selectDefaultExportDirectoryButton.Location = new System.Drawing.Point(440, 26);
			this._selectDefaultExportDirectoryButton.Name = "_selectDefaultExportDirectoryButton";
			this._selectDefaultExportDirectoryButton.Size = new System.Drawing.Size(38, 23);
			this._selectDefaultExportDirectoryButton.TabIndex = 2;
			this._selectDefaultExportDirectoryButton.Text = "...";
			this._selectDefaultExportDirectoryButton.UseVisualStyleBackColor = true;
			this._selectDefaultExportDirectoryButton.Click += new System.EventHandler(this.SelectDefaultExportDirectoryButtonClick);
			// 
			// _defaultExportDirectoryTextBox
			// 
			this._defaultExportDirectoryTextBox.Location = new System.Drawing.Point(152, 26);
			this._defaultExportDirectoryTextBox.Name = "_defaultExportDirectoryTextBox";
			this._defaultExportDirectoryTextBox.Size = new System.Drawing.Size(282, 20);
			this._defaultExportDirectoryTextBox.TabIndex = 1;
			// 
			// _defaultExportDirectoryLabel
			// 
			this._defaultExportDirectoryLabel.AutoSize = true;
			this._defaultExportDirectoryLabel.Location = new System.Drawing.Point(6, 26);
			this._defaultExportDirectoryLabel.Name = "_defaultExportDirectoryLabel";
			this._defaultExportDirectoryLabel.Size = new System.Drawing.Size(119, 13);
			this._defaultExportDirectoryLabel.TabIndex = 0;
			this._defaultExportDirectoryLabel.Text = "Default export directory:";
			// 
			// _startupGroupBox
			// 
			this._startupGroupBox.Controls.Add(this._defaultDateIntervalFilterComboBox);
			this._startupGroupBox.Controls.Add(this.label1);
			this._startupGroupBox.Controls.Add(this._loadLogsFromDefaultDirectoryAtStartupCheckBox);
			this._startupGroupBox.Controls.Add(this._selectDefaultLogsDirectoryButton);
			this._startupGroupBox.Controls.Add(this._defaultLogsDirectoryTextBox);
			this._startupGroupBox.Controls.Add(this._defaultLogsDirectoryLabel);
			this._startupGroupBox.Controls.Add(this._numberOfLogsToLoadComboBox);
			this._startupGroupBox.Controls.Add(this._maxNumberOfLogsLabel);
			this._startupGroupBox.Location = new System.Drawing.Point(12, 12);
			this._startupGroupBox.Name = "_startupGroupBox";
			this._startupGroupBox.Size = new System.Drawing.Size(489, 163);
			this._startupGroupBox.TabIndex = 0;
			this._startupGroupBox.TabStop = false;
			this._startupGroupBox.Text = "Startup";
			// 
			// _defaultDateIntervalFilterComboBox
			// 
			this._defaultDateIntervalFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._defaultDateIntervalFilterComboBox.FormattingEnabled = true;
			this._defaultDateIntervalFilterComboBox.Location = new System.Drawing.Point(150, 29);
			this._defaultDateIntervalFilterComboBox.Name = "_defaultDateIntervalFilterComboBox";
			this._defaultDateIntervalFilterComboBox.Size = new System.Drawing.Size(282, 21);
			this._defaultDateIntervalFilterComboBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search filter default interval:";
			// 
			// _loadLogsFromDefaultDirectoryAtStartupCheckBox
			// 
			this._loadLogsFromDefaultDirectoryAtStartupCheckBox.AutoSize = true;
			this._loadLogsFromDefaultDirectoryAtStartupCheckBox.Location = new System.Drawing.Point(150, 130);
			this._loadLogsFromDefaultDirectoryAtStartupCheckBox.Name = "_loadLogsFromDefaultDirectoryAtStartupCheckBox";
			this._loadLogsFromDefaultDirectoryAtStartupCheckBox.Size = new System.Drawing.Size(183, 17);
			this._loadLogsFromDefaultDirectoryAtStartupCheckBox.TabIndex = 7;
			this._loadLogsFromDefaultDirectoryAtStartupCheckBox.Text = "Load logs automatically at startup";
			this._loadLogsFromDefaultDirectoryAtStartupCheckBox.UseVisualStyleBackColor = true;
			// 
			// _selectDefaultLogsDirectoryButton
			// 
			this._selectDefaultLogsDirectoryButton.Location = new System.Drawing.Point(441, 104);
			this._selectDefaultLogsDirectoryButton.Name = "_selectDefaultLogsDirectoryButton";
			this._selectDefaultLogsDirectoryButton.Size = new System.Drawing.Size(38, 23);
			this._selectDefaultLogsDirectoryButton.TabIndex = 6;
			this._selectDefaultLogsDirectoryButton.Text = "...";
			this._selectDefaultLogsDirectoryButton.UseVisualStyleBackColor = true;
			this._selectDefaultLogsDirectoryButton.Click += new System.EventHandler(this.SelectDefaultLogsDirectoryButtonClick);
			// 
			// _defaultLogsDirectoryTextBox
			// 
			this._defaultLogsDirectoryTextBox.Location = new System.Drawing.Point(150, 104);
			this._defaultLogsDirectoryTextBox.Name = "_defaultLogsDirectoryTextBox";
			this._defaultLogsDirectoryTextBox.Size = new System.Drawing.Size(285, 20);
			this._defaultLogsDirectoryTextBox.TabIndex = 5;
			// 
			// _defaultLogsDirectoryLabel
			// 
			this._defaultLogsDirectoryLabel.AutoSize = true;
			this._defaultLogsDirectoryLabel.Location = new System.Drawing.Point(7, 104);
			this._defaultLogsDirectoryLabel.Name = "_defaultLogsDirectoryLabel";
			this._defaultLogsDirectoryLabel.Size = new System.Drawing.Size(109, 13);
			this._defaultLogsDirectoryLabel.TabIndex = 4;
			this._defaultLogsDirectoryLabel.Text = "Default logs directory:";
			// 
			// _numberOfLogsToLoadComboBox
			// 
			this._numberOfLogsToLoadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._numberOfLogsToLoadComboBox.FormattingEnabled = true;
			this._numberOfLogsToLoadComboBox.Location = new System.Drawing.Point(150, 66);
			this._numberOfLogsToLoadComboBox.Name = "_numberOfLogsToLoadComboBox";
			this._numberOfLogsToLoadComboBox.Size = new System.Drawing.Size(113, 21);
			this._numberOfLogsToLoadComboBox.TabIndex = 3;
			// 
			// _maxNumberOfLogsLabel
			// 
			this._maxNumberOfLogsLabel.AutoSize = true;
			this._maxNumberOfLogsLabel.Location = new System.Drawing.Point(6, 69);
			this._maxNumberOfLogsLabel.Name = "_maxNumberOfLogsLabel";
			this._maxNumberOfLogsLabel.Size = new System.Drawing.Size(137, 13);
			this._maxNumberOfLogsLabel.TabIndex = 2;
			this._maxNumberOfLogsLabel.Text = "Max number of logs to load:";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 305);
			this.Controls.Add(this._startupGroupBox);
			this.Controls.Add(this._exportGroupBox);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._saveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			this._exportGroupBox.ResumeLayout(false);
			this._exportGroupBox.PerformLayout();
			this._startupGroupBox.ResumeLayout(false);
			this._startupGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _saveButton;
		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
		private System.Windows.Forms.GroupBox _exportGroupBox;
		private System.Windows.Forms.Button _selectDefaultExportDirectoryButton;
		private System.Windows.Forms.TextBox _defaultExportDirectoryTextBox;
		private System.Windows.Forms.Label _defaultExportDirectoryLabel;
		private System.Windows.Forms.GroupBox _startupGroupBox;
		private System.Windows.Forms.ComboBox _numberOfLogsToLoadComboBox;
		private System.Windows.Forms.Label _maxNumberOfLogsLabel;
		private System.Windows.Forms.Label _defaultLogsDirectoryLabel;
		private System.Windows.Forms.TextBox _defaultLogsDirectoryTextBox;
		private System.Windows.Forms.Button _selectDefaultLogsDirectoryButton;
		private System.Windows.Forms.CheckBox _loadLogsFromDefaultDirectoryAtStartupCheckBox;
		private System.Windows.Forms.ComboBox _defaultDateIntervalFilterComboBox;
		private System.Windows.Forms.Label label1;
	}
}