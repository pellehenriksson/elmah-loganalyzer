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
			this._ninjecLinkLabel = new System.Windows.Forms.LinkLabel();
			this._nLogLinkLabel = new System.Windows.Forms.LinkLabel();
			this._dapperLabel = new System.Windows.Forms.Label();
			this._dapperLinkLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// _closeButton
			// 
			this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._closeButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._closeButton.Location = new System.Drawing.Point(335, 227);
			this._closeButton.Name = "_closeButton";
			this._closeButton.Size = new System.Drawing.Size(75, 23);
			this._closeButton.TabIndex = 0;
			this._closeButton.Text = "Close";
			this._closeButton.UseVisualStyleBackColor = true;
			// 
			// _infoLabel
			// 
			this._infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._infoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Get the latest version from:";
			// 
			// _updateLinkLabel
			// 
			this._updateLinkLabel.AutoSize = true;
			this._updateLinkLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._updateLinkLabel.Location = new System.Drawing.Point(151, 65);
			this._updateLinkLabel.Name = "_updateLinkLabel";
			this._updateLinkLabel.Size = new System.Drawing.Size(265, 13);
			this._updateLinkLabel.TabIndex = 3;
			this._updateLinkLabel.TabStop = true;
			this._updateLinkLabel.Text = "https://github.com/pellehenriksson/elmah-loganalyzer";
			this._updateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateLinkLabelLinkClicked);
			// 
			// _silkLabel
			// 
			this._silkLabel.AutoSize = true;
			this._silkLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._silkLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._silkLabel.Location = new System.Drawing.Point(12, 110);
			this._silkLabel.Name = "_silkLabel";
			this._silkLabel.Size = new System.Drawing.Size(81, 13);
			this._silkLabel.TabIndex = 4;
			this._silkLabel.Text = "Silk icon set 1.3";
			// 
			// _silkLinkLabel
			// 
			this._silkLinkLabel.AutoSize = true;
			this._silkLinkLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._silkLinkLabel.Location = new System.Drawing.Point(151, 110);
			this._silkLinkLabel.Name = "_silkLinkLabel";
			this._silkLinkLabel.Size = new System.Drawing.Size(208, 13);
			this._silkLinkLabel.TabIndex = 5;
			this._silkLinkLabel.TabStop = true;
			this._silkLinkLabel.Text = "http://www.famfamfam.com/lab/icons/silk";
			this._silkLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SilkLinkLabelLinkClicked);
			// 
			// _ninjectLabel
			// 
			this._ninjectLabel.AutoSize = true;
			this._ninjectLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._ninjectLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._ninjectLabel.Location = new System.Drawing.Point(54, 136);
			this._ninjectLabel.Name = "_ninjectLabel";
			this._ninjectLabel.Size = new System.Drawing.Size(40, 13);
			this._ninjectLabel.TabIndex = 6;
			this._ninjectLabel.Text = "Ninject";
			// 
			// _nLogLabel
			// 
			this._nLogLabel.AutoSize = true;
			this._nLogLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._nLogLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._nLogLabel.Location = new System.Drawing.Point(61, 168);
			this._nLogLabel.Name = "_nLogLabel";
			this._nLogLabel.Size = new System.Drawing.Size(31, 13);
			this._nLogLabel.TabIndex = 7;
			this._nLogLabel.Text = "NLog";
			// 
			// _ninjecLinkLabel
			// 
			this._ninjecLinkLabel.AutoSize = true;
			this._ninjecLinkLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._ninjecLinkLabel.Location = new System.Drawing.Point(151, 136);
			this._ninjecLinkLabel.Name = "_ninjecLinkLabel";
			this._ninjecLinkLabel.Size = new System.Drawing.Size(91, 13);
			this._ninjecLinkLabel.TabIndex = 8;
			this._ninjecLinkLabel.TabStop = true;
			this._ninjecLinkLabel.Text = "http://ninject.org";
			this._ninjecLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NinjecLinkLabelLinkClicked);
			// 
			// _nLogLinkLabel
			// 
			this._nLogLinkLabel.AutoSize = true;
			this._nLogLinkLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._nLogLinkLabel.Location = new System.Drawing.Point(151, 168);
			this._nLogLinkLabel.Name = "_nLogLinkLabel";
			this._nLogLinkLabel.Size = new System.Drawing.Size(117, 13);
			this._nLogLinkLabel.TabIndex = 9;
			this._nLogLinkLabel.TabStop = true;
			this._nLogLinkLabel.Text = "http://nlog-project.org";
			this._nLogLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NLogLinkLabelLinkClicked);
			// 
			// _dapperLabel
			// 
			this._dapperLabel.AutoSize = true;
			this._dapperLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._dapperLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._dapperLabel.Location = new System.Drawing.Point(18, 196);
			this._dapperLabel.Name = "_dapperLabel";
			this._dapperLabel.Size = new System.Drawing.Size(81, 13);
			this._dapperLabel.TabIndex = 10;
			this._dapperLabel.Text = "dapper-dot-net";
			// 
			// _dapperLinkLabel
			// 
			this._dapperLinkLabel.AutoSize = true;
			this._dapperLinkLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._dapperLinkLabel.Location = new System.Drawing.Point(151, 196);
			this._dapperLinkLabel.Name = "_dapperLinkLabel";
			this._dapperLinkLabel.Size = new System.Drawing.Size(213, 13);
			this._dapperLinkLabel.TabIndex = 11;
			this._dapperLinkLabel.TabStop = true;
			this._dapperLinkLabel.Text = "https://github.com/StackExchange/Dapper";
			this._dapperLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DapperLinkLabelLinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 262);
			this.Controls.Add(this._dapperLinkLabel);
			this.Controls.Add(this._dapperLabel);
			this.Controls.Add(this._nLogLinkLabel);
			this.Controls.Add(this._ninjecLinkLabel);
			this.Controls.Add(this._nLogLabel);
			this.Controls.Add(this._ninjectLabel);
			this.Controls.Add(this._silkLinkLabel);
			this.Controls.Add(this._silkLabel);
			this.Controls.Add(this._updateLinkLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._infoLabel);
			this.Controls.Add(this._closeButton);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
		private System.Windows.Forms.LinkLabel _ninjecLinkLabel;
		private System.Windows.Forms.LinkLabel _nLogLinkLabel;
		private System.Windows.Forms.Label _dapperLabel;
		private System.Windows.Forms.LinkLabel _dapperLinkLabel;
	}
}