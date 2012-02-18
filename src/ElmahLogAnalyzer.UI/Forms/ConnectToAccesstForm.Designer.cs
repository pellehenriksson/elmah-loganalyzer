namespace ElmahLogAnalyzer.UI.Forms
{
	partial class ConnectToAccessForm
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
			this._connectButton = new System.Windows.Forms.Button();
			this._serverTextBox = new System.Windows.Forms.TextBox();
			this._serverLabel = new System.Windows.Forms.Label();
			this._browseButton = new System.Windows.Forms.Button();
			this._errorGroupBox = new System.Windows.Forms.GroupBox();
			this._errorMessageLabel = new System.Windows.Forms.Label();
			this._errorGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._cancelButton.Location = new System.Drawing.Point(322, 194);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 15;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			// 
			// _connectButton
			// 
			this._connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._connectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._connectButton.Location = new System.Drawing.Point(241, 194);
			this._connectButton.Name = "_connectButton";
			this._connectButton.Size = new System.Drawing.Size(75, 23);
			this._connectButton.TabIndex = 14;
			this._connectButton.Text = "Connect";
			this._connectButton.UseVisualStyleBackColor = true;
			// 
			// _serverTextBox
			// 
			this._serverTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverTextBox.Location = new System.Drawing.Point(82, 54);
			this._serverTextBox.Name = "_serverTextBox";
			this._serverTextBox.Size = new System.Drawing.Size(278, 21);
			this._serverTextBox.TabIndex = 21;
			// 
			// _serverLabel
			// 
			this._serverLabel.AutoSize = true;
			this._serverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._serverLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverLabel.Location = new System.Drawing.Point(15, 51);
			this._serverLabel.Name = "_serverLabel";
			this._serverLabel.Size = new System.Drawing.Size(43, 13);
			this._serverLabel.TabIndex = 20;
			this._serverLabel.Text = "Server:";
			// 
			// _browseButton
			// 
			this._browseButton.Location = new System.Drawing.Point(366, 54);
			this._browseButton.Name = "_browseButton";
			this._browseButton.Size = new System.Drawing.Size(29, 23);
			this._browseButton.TabIndex = 22;
			this._browseButton.Text = "...";
			this._browseButton.UseVisualStyleBackColor = true;
			// 
			// _errorGroupBox
			// 
			this._errorGroupBox.Controls.Add(this._errorMessageLabel);
			this._errorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._errorGroupBox.Location = new System.Drawing.Point(82, 81);
			this._errorGroupBox.Name = "_errorGroupBox";
			this._errorGroupBox.Size = new System.Drawing.Size(315, 100);
			this._errorGroupBox.TabIndex = 28;
			this._errorGroupBox.TabStop = false;
			this._errorGroupBox.Text = "Connection failed";
			// 
			// _errorMessageLabel
			// 
			this._errorMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._errorMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._errorMessageLabel.Location = new System.Drawing.Point(3, 17);
			this._errorMessageLabel.Name = "_errorMessageLabel";
			this._errorMessageLabel.Size = new System.Drawing.Size(309, 80);
			this._errorMessageLabel.TabIndex = 0;
			// 
			// ConnectToAccessForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 229);
			this.Controls.Add(this._errorGroupBox);
			this.Controls.Add(this._browseButton);
			this.Controls.Add(this._serverTextBox);
			this.Controls.Add(this._serverLabel);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._connectButton);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectToAccessForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to Microsoft Access";
			this._errorGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _connectButton;
		private System.Windows.Forms.TextBox _serverTextBox;
		private System.Windows.Forms.Label _serverLabel;
		private System.Windows.Forms.Button _browseButton;
		private System.Windows.Forms.GroupBox _errorGroupBox;
		private System.Windows.Forms.Label _errorMessageLabel;
	}
}