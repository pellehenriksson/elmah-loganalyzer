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
			this._loadingPictureBox = new System.Windows.Forms.PictureBox();
			this._progressLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._loadingPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.Location = new System.Drawing.Point(466, 224);
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
			this._exportButton.Location = new System.Drawing.Point(385, 224);
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
			this._infoLabel.Size = new System.Drawing.Size(529, 121);
			this._infoLabel.TabIndex = 6;
			this._infoLabel.Text = "[Info]";
			// 
			// _loadingPictureBox
			// 
			this._loadingPictureBox.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.loading;
			this._loadingPictureBox.Location = new System.Drawing.Point(229, 142);
			this._loadingPictureBox.Name = "_loadingPictureBox";
			this._loadingPictureBox.Size = new System.Drawing.Size(100, 100);
			this._loadingPictureBox.TabIndex = 7;
			this._loadingPictureBox.TabStop = false;
			// 
			// _progressLabel
			// 
			this._progressLabel.AutoSize = true;
			this._progressLabel.Location = new System.Drawing.Point(12, 142);
			this._progressLabel.Name = "_progressLabel";
			this._progressLabel.Size = new System.Drawing.Size(54, 13);
			this._progressLabel.TabIndex = 8;
			this._progressLabel.Text = "[Progress]";
			// 
			// ExportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 259);
			this.Controls.Add(this._progressLabel);
			this.Controls.Add(this._loadingPictureBox);
			this.Controls.Add(this._infoLabel);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._exportButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Export";
			((System.ComponentModel.ISupportInitialize)(this._loadingPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _exportButton;
		private System.Windows.Forms.Label _infoLabel;
		private System.Windows.Forms.PictureBox _loadingPictureBox;
		private System.Windows.Forms.Label _progressLabel;
	}
}