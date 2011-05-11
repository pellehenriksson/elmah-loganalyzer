namespace Crepido.ElmahOfflineViewer.UI.Forms
{
	partial class AboutForm
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
			this._closeButton = new System.Windows.Forms.Button();
			this._infoLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._updateLinkLabel = new System.Windows.Forms.LinkLabel();
			this._thanksLabel = new System.Windows.Forms.Label();
			this._thanksLinkLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// _closeButton
			// 
			this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._closeButton.Location = new System.Drawing.Point(365, 145);
			this._closeButton.Name = "_closeButton";
			this._closeButton.Size = new System.Drawing.Size(75, 23);
			this._closeButton.TabIndex = 0;
			this._closeButton.Text = "Close";
			this._closeButton.UseVisualStyleBackColor = true;
			// 
			// _infoLabel
			// 
			this._infoLabel.Location = new System.Drawing.Point(12, 9);
			this._infoLabel.Name = "_infoLabel";
			this._infoLabel.Size = new System.Drawing.Size(428, 45);
			this._infoLabel.TabIndex = 1;
			this._infoLabel.Text = "The ELMAH Offline Viewer is an open source project started by by Pelle Henriksson" +
    " in 2011 (pelle.henriksson@google.com)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Get the latest version from:";
			// 
			// _updateLinkLabel
			// 
			this._updateLinkLabel.AutoSize = true;
			this._updateLinkLabel.Location = new System.Drawing.Point(151, 65);
			this._updateLinkLabel.Name = "_updateLinkLabel";
			this._updateLinkLabel.Size = new System.Drawing.Size(228, 13);
			this._updateLinkLabel.TabIndex = 3;
			this._updateLinkLabel.TabStop = true;
			this._updateLinkLabel.Text = "http://code.google.com/p/elmahofflineviewer/";
			this._updateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateLinkLabelLinkClicked);
			// 
			// _thanksLabel
			// 
			this._thanksLabel.AutoSize = true;
			this._thanksLabel.Location = new System.Drawing.Point(12, 95);
			this._thanksLabel.Name = "_thanksLabel";
			this._thanksLabel.Size = new System.Drawing.Size(168, 13);
			this._thanksLabel.TabIndex = 4;
			this._thanksLabel.Text = "This tool uses the Silk icon set 1.3";
			// 
			// _thanksLinkLabel
			// 
			this._thanksLinkLabel.AutoSize = true;
			this._thanksLinkLabel.Location = new System.Drawing.Point(187, 95);
			this._thanksLinkLabel.Name = "_thanksLinkLabel";
			this._thanksLinkLabel.Size = new System.Drawing.Size(213, 13);
			this._thanksLinkLabel.TabIndex = 5;
			this._thanksLinkLabel.TabStop = true;
			this._thanksLinkLabel.Text = "http://www.famfamfam.com/lab/icons/silk/";
			this._thanksLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ThanksLinkLabelLinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 180);
			this.Controls.Add(this._thanksLinkLabel);
			this.Controls.Add(this._thanksLabel);
			this.Controls.Add(this._updateLinkLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._infoLabel);
			this.Controls.Add(this._closeButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About ELMAH Offline Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _closeButton;
		private System.Windows.Forms.Label _infoLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel _updateLinkLabel;
		private System.Windows.Forms.Label _thanksLabel;
		private System.Windows.Forms.LinkLabel _thanksLinkLabel;
	}
}