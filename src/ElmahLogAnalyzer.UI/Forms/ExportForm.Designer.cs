namespace ElmahLogAnalyzer.UI.Forms
{
	partial class ExportForm
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
			this._cancelButton = new System.Windows.Forms.Button();
			this._exportButton = new System.Windows.Forms.Button();
			this._infoLabel = new System.Windows.Forms.Label();
			this._progressLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._exportToDirectoryTextBox = new System.Windows.Forms.TextBox();
			this._selectExportToDirectoryButton = new System.Windows.Forms.Button();
			this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.Location = new System.Drawing.Point(416, 171);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 5;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// _exportButton
			// 
			this._exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._exportButton.Location = new System.Drawing.Point(335, 171);
			this._exportButton.Name = "_exportButton";
			this._exportButton.Size = new System.Drawing.Size(75, 23);
			this._exportButton.TabIndex = 4;
			this._exportButton.Text = "Export";
			this._exportButton.UseVisualStyleBackColor = true;
			this._exportButton.Click += new System.EventHandler(this.ExportButtonClick);
			// 
			// _infoLabel
			// 
			this._infoLabel.Location = new System.Drawing.Point(12, 9);
			this._infoLabel.Name = "_infoLabel";
			this._infoLabel.Size = new System.Drawing.Size(473, 82);
			this._infoLabel.TabIndex = 6;
			this._infoLabel.Text = "[Info]";
			// 
			// _progressLabel
			// 
			this._progressLabel.AutoSize = true;
			this._progressLabel.Location = new System.Drawing.Point(12, 137);
			this._progressLabel.Name = "_progressLabel";
			this._progressLabel.Size = new System.Drawing.Size(54, 13);
			this._progressLabel.TabIndex = 8;
			this._progressLabel.Text = "[Progress]";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Export to directory:";
			// 
			// _exportToDirectoryTextBox
			// 
			this._exportToDirectoryTextBox.Location = new System.Drawing.Point(113, 108);
			this._exportToDirectoryTextBox.Name = "_exportToDirectoryTextBox";
			this._exportToDirectoryTextBox.Size = new System.Drawing.Size(334, 20);
			this._exportToDirectoryTextBox.TabIndex = 10;
			// 
			// _selectExportToDirectoryButton
			// 
			this._selectExportToDirectoryButton.Location = new System.Drawing.Point(453, 108);
			this._selectExportToDirectoryButton.Name = "_selectExportToDirectoryButton";
			this._selectExportToDirectoryButton.Size = new System.Drawing.Size(38, 23);
			this._selectExportToDirectoryButton.TabIndex = 11;
			this._selectExportToDirectoryButton.Text = "...";
			this._selectExportToDirectoryButton.UseVisualStyleBackColor = true;
			this._selectExportToDirectoryButton.Click += new System.EventHandler(this.SelectExportToDirectoryButtonClick);
			// 
			// ExportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 206);
			this.Controls.Add(this._selectExportToDirectoryButton);
			this.Controls.Add(this._exportToDirectoryTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._progressLabel);
			this.Controls.Add(this._infoLabel);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._exportButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Export";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.Load += new System.EventHandler(this.ExportFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _exportButton;
		private System.Windows.Forms.Label _infoLabel;
		private System.Windows.Forms.Label _progressLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _exportToDirectoryTextBox;
		private System.Windows.Forms.Button _selectExportToDirectoryButton;
		private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
	}
}