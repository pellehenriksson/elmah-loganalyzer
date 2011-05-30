namespace ElmahLogAnalyzer.UI.Forms
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
			this._silkLabel = new System.Windows.Forms.Label();
			this._silkLinkLabel = new System.Windows.Forms.LinkLabel();
			this._ninjectLabel = new System.Windows.Forms.Label();
			this._nLogLabel = new System.Windows.Forms.Label();
			this.ninjecLinkLabel = new System.Windows.Forms.LinkLabel();
			this.nLogLinkLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// _closeButton
			// 
			this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._closeButton.Location = new System.Drawing.Point(365, 196);
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
			this._infoLabel.Size = new System.Drawing.Size(428, 38);
			this._infoLabel.TabIndex = 1;
			this._infoLabel.Text = "The ELMAH Log Analyzer is an open source project started by pelle.henriksson@gmai" +
    "l.com";
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
			this._updateLinkLabel.Size = new System.Drawing.Size(220, 13);
			this._updateLinkLabel.TabIndex = 3;
			this._updateLinkLabel.TabStop = true;
			this._updateLinkLabel.Text = "http://code.google.com/p/elmah-loganalyzer";
			this._updateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(UpdateLinkLabelLinkClicked);
			// 
			// _silkLabel
			// 
			this._silkLabel.AutoSize = true;
			this._silkLabel.Location = new System.Drawing.Point(12, 110);
			this._silkLabel.Name = "_silkLabel";
			this._silkLabel.Size = new System.Drawing.Size(82, 13);
			this._silkLabel.TabIndex = 4;
			this._silkLabel.Text = "Silk icon set 1.3";
			// 
			// _silkLinkLabel
			// 
			this._silkLinkLabel.AutoSize = true;
			this._silkLinkLabel.Location = new System.Drawing.Point(120, 110);
			this._silkLinkLabel.Name = "_silkLinkLabel";
			this._silkLinkLabel.Size = new System.Drawing.Size(208, 13);
			this._silkLinkLabel.TabIndex = 5;
			this._silkLinkLabel.TabStop = true;
			this._silkLinkLabel.Text = "http://www.famfamfam.com/lab/icons/silk";
			this._silkLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(SilkLinkLabelLinkClicked);
			// 
			// _ninjectLabel
			// 
			this._ninjectLabel.AutoSize = true;
			this._ninjectLabel.Location = new System.Drawing.Point(54, 136);
			this._ninjectLabel.Name = "_ninjectLabel";
			this._ninjectLabel.Size = new System.Drawing.Size(40, 13);
			this._ninjectLabel.TabIndex = 6;
			this._ninjectLabel.Text = "Ninject";
			// 
			// _nLogLabel
			// 
			this._nLogLabel.AutoSize = true;
			this._nLogLabel.Location = new System.Drawing.Point(61, 168);
			this._nLogLabel.Name = "_nLogLabel";
			this._nLogLabel.Size = new System.Drawing.Size(33, 13);
			this._nLogLabel.TabIndex = 7;
			this._nLogLabel.Text = "NLog";
			// 
			// ninjecLinkLabel
			// 
			this.ninjecLinkLabel.AutoSize = true;
			this.ninjecLinkLabel.Location = new System.Drawing.Point(120, 136);
			this.ninjecLinkLabel.Name = "ninjecLinkLabel";
			this.ninjecLinkLabel.Size = new System.Drawing.Size(87, 13);
			this.ninjecLinkLabel.TabIndex = 8;
			this.ninjecLinkLabel.TabStop = true;
			this.ninjecLinkLabel.Text = "http://ninject.org";
			this.ninjecLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(NinjecLinkLabelLinkClicked);
			// 
			// nLogLinkLabel
			// 
			this.nLogLinkLabel.AutoSize = true;
			this.nLogLinkLabel.Location = new System.Drawing.Point(120, 168);
			this.nLogLinkLabel.Name = "nLogLinkLabel";
			this.nLogLinkLabel.Size = new System.Drawing.Size(111, 13);
			this.nLogLinkLabel.TabIndex = 9;
			this.nLogLinkLabel.TabStop = true;
			this.nLogLinkLabel.Text = "http://nlog-project.org";
			this.nLogLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(NLogLinkLabelLinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 231);
			this.Controls.Add(this.nLogLinkLabel);
			this.Controls.Add(this.ninjecLinkLabel);
			this.Controls.Add(this._nLogLabel);
			this.Controls.Add(this._ninjectLabel);
			this.Controls.Add(this._silkLinkLabel);
			this.Controls.Add(this._silkLabel);
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
			this.Text = "About ELMAH Log Analyzer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _closeButton;
		private System.Windows.Forms.Label _infoLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel _updateLinkLabel;
		private System.Windows.Forms.Label _silkLabel;
		private System.Windows.Forms.LinkLabel _silkLinkLabel;
		private System.Windows.Forms.Label _ninjectLabel;
		private System.Windows.Forms.Label _nLogLabel;
		private System.Windows.Forms.LinkLabel ninjecLinkLabel;
		private System.Windows.Forms.LinkLabel nLogLinkLabel;
	}
}