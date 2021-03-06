﻿namespace ElmahLogAnalyzer.UI.Forms
{
	partial class ConnectToSqlServerCompactForm
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
			this._connectionLabel = new System.Windows.Forms.Label();
			this._connectionComboBox = new System.Windows.Forms.ComboBox();
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
			this._cancelButton.TabIndex = 7;
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
			this._connectButton.TabIndex = 6;
			this._connectButton.Text = "Connect";
			this._connectButton.UseVisualStyleBackColor = true;
			// 
			// _serverTextBox
			// 
			this._serverTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverTextBox.Location = new System.Drawing.Point(82, 54);
			this._serverTextBox.Name = "_serverTextBox";
			this._serverTextBox.Size = new System.Drawing.Size(278, 21);
			this._serverTextBox.TabIndex = 3;
			// 
			// _serverLabel
			// 
			this._serverLabel.AutoSize = true;
			this._serverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._serverLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverLabel.Location = new System.Drawing.Point(12, 54);
			this._serverLabel.Name = "_serverLabel";
			this._serverLabel.Size = new System.Drawing.Size(27, 13);
			this._serverLabel.TabIndex = 2;
			this._serverLabel.Text = "File:";
			// 
			// _browseButton
			// 
			this._browseButton.Location = new System.Drawing.Point(366, 54);
			this._browseButton.Name = "_browseButton";
			this._browseButton.Size = new System.Drawing.Size(29, 23);
			this._browseButton.TabIndex = 4;
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
			this._errorGroupBox.TabIndex = 5;
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
			// _connectionLabel
			// 
			this._connectionLabel.AutoSize = true;
			this._connectionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._connectionLabel.Location = new System.Drawing.Point(11, 12);
			this._connectionLabel.Name = "_connectionLabel";
			this._connectionLabel.Size = new System.Drawing.Size(65, 13);
			this._connectionLabel.TabIndex = 0;
			this._connectionLabel.Text = "Connection:";
			// 
			// _connectionComboBox
			// 
			this._connectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._connectionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._connectionComboBox.FormattingEnabled = true;
			this._connectionComboBox.Location = new System.Drawing.Point(82, 12);
			this._connectionComboBox.Name = "_connectionComboBox";
			this._connectionComboBox.Size = new System.Drawing.Size(312, 21);
			this._connectionComboBox.TabIndex = 1;
			// 
			// ConnectToSqlServerCompactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 229);
			this.Controls.Add(this._connectionComboBox);
			this.Controls.Add(this._connectionLabel);
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
			this.Name = "ConnectToSqlServerCompactForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to Sql Server Compact";
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
		private System.Windows.Forms.Label _connectionLabel;
		private System.Windows.Forms.ComboBox _connectionComboBox;
	}
}