namespace ElmahLogAnalyzer.UI.Forms
{
	partial class ConnectToWebServerForm
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
			this._serverLabel = new System.Windows.Forms.Label();
			this._serverSampleLabel = new System.Windows.Forms.Label();
			this._errorGroupBox = new System.Windows.Forms.GroupBox();
			this._errorMessageLabel = new System.Windows.Forms.Label();
			this._usernameLabel = new System.Windows.Forms.Label();
			this._userNameTextBox = new System.Windows.Forms.TextBox();
			this._passwordTextBox = new System.Windows.Forms.TextBox();
			this._passwordLabel = new System.Windows.Forms.Label();
			this._domainTextBox = new System.Windows.Forms.TextBox();
			this._domainLabel = new System.Windows.Forms.Label();
			this._credentialsInfoLabel = new System.Windows.Forms.Label();
			this._urlComboBox = new System.Windows.Forms.ComboBox();
			this._errorGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._cancelButton.Location = new System.Drawing.Point(414, 226);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 11;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// _connectButton
			// 
			this._connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._connectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._connectButton.Location = new System.Drawing.Point(333, 226);
			this._connectButton.Name = "_connectButton";
			this._connectButton.Size = new System.Drawing.Size(75, 23);
			this._connectButton.TabIndex = 10;
			this._connectButton.Text = "Connect";
			this._connectButton.UseVisualStyleBackColor = true;
			this._connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
			// 
			// _serverLabel
			// 
			this._serverLabel.AutoSize = true;
			this._serverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._serverLabel.Location = new System.Drawing.Point(12, 18);
			this._serverLabel.Name = "_serverLabel";
			this._serverLabel.Size = new System.Drawing.Size(58, 13);
			this._serverLabel.TabIndex = 0;
			this._serverLabel.Text = "Server url:";
			// 
			// _serverSampleLabel
			// 
			this._serverSampleLabel.AutoSize = true;
			this._serverSampleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._serverSampleLabel.Location = new System.Drawing.Point(92, 42);
			this._serverSampleLabel.Name = "_serverSampleLabel";
			this._serverSampleLabel.Size = new System.Drawing.Size(223, 13);
			this._serverSampleLabel.TabIndex = 2;
			this._serverSampleLabel.Text = "Example: http://www.myapp.com/elmah.axd";
			// 
			// _errorGroupBox
			// 
			this._errorGroupBox.Controls.Add(this._errorMessageLabel);
			this._errorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._errorGroupBox.Location = new System.Drawing.Point(89, 153);
			this._errorGroupBox.Name = "_errorGroupBox";
			this._errorGroupBox.Size = new System.Drawing.Size(400, 66);
			this._errorGroupBox.TabIndex = 9;
			this._errorGroupBox.TabStop = false;
			this._errorGroupBox.Text = "Connection failed";
			// 
			// _errorMessageLabel
			// 
			this._errorMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._errorMessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._errorMessageLabel.Location = new System.Drawing.Point(3, 17);
			this._errorMessageLabel.Name = "_errorMessageLabel";
			this._errorMessageLabel.Size = new System.Drawing.Size(394, 46);
			this._errorMessageLabel.TabIndex = 0;
			// 
			// _usernameLabel
			// 
			this._usernameLabel.AutoSize = true;
			this._usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._usernameLabel.Location = new System.Drawing.Point(15, 75);
			this._usernameLabel.Name = "_usernameLabel";
			this._usernameLabel.Size = new System.Drawing.Size(62, 13);
			this._usernameLabel.TabIndex = 3;
			this._usernameLabel.Text = "User name:";
			// 
			// _userNameTextBox
			// 
			this._userNameTextBox.Location = new System.Drawing.Point(89, 75);
			this._userNameTextBox.Name = "_userNameTextBox";
			this._userNameTextBox.Size = new System.Drawing.Size(259, 21);
			this._userNameTextBox.TabIndex = 4;
			// 
			// _passwordTextBox
			// 
			this._passwordTextBox.Location = new System.Drawing.Point(89, 101);
			this._passwordTextBox.Name = "_passwordTextBox";
			this._passwordTextBox.PasswordChar = '*';
			this._passwordTextBox.Size = new System.Drawing.Size(259, 21);
			this._passwordTextBox.TabIndex = 6;
			// 
			// _passwordLabel
			// 
			this._passwordLabel.AutoSize = true;
			this._passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._passwordLabel.Location = new System.Drawing.Point(15, 104);
			this._passwordLabel.Name = "_passwordLabel";
			this._passwordLabel.Size = new System.Drawing.Size(57, 13);
			this._passwordLabel.TabIndex = 5;
			this._passwordLabel.Text = "Password:";
			// 
			// _domainTextBox
			// 
			this._domainTextBox.Location = new System.Drawing.Point(89, 127);
			this._domainTextBox.Name = "_domainTextBox";
			this._domainTextBox.Size = new System.Drawing.Size(259, 21);
			this._domainTextBox.TabIndex = 8;
			// 
			// _domainLabel
			// 
			this._domainLabel.AutoSize = true;
			this._domainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._domainLabel.Location = new System.Drawing.Point(15, 130);
			this._domainLabel.Name = "_domainLabel";
			this._domainLabel.Size = new System.Drawing.Size(46, 13);
			this._domainLabel.TabIndex = 7;
			this._domainLabel.Text = "Domain:";
			// 
			// _credentialsInfoLabel
			// 
			this._credentialsInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._credentialsInfoLabel.Location = new System.Drawing.Point(358, 88);
			this._credentialsInfoLabel.Name = "_credentialsInfoLabel";
			this._credentialsInfoLabel.Size = new System.Drawing.Size(131, 46);
			this._credentialsInfoLabel.TabIndex = 12;
			this._credentialsInfoLabel.Text = "Not required unless you need to supply Windows credentials to the server.";
			// 
			// _urlComboBox
			// 
			this._urlComboBox.FormattingEnabled = true;
			this._urlComboBox.Location = new System.Drawing.Point(89, 18);
			this._urlComboBox.Name = "_urlComboBox";
			this._urlComboBox.Size = new System.Drawing.Size(397, 21);
			this._urlComboBox.TabIndex = 1;
			// 
			// ConnectToWebServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 261);
			this.Controls.Add(this._urlComboBox);
			this.Controls.Add(this._credentialsInfoLabel);
			this.Controls.Add(this._domainLabel);
			this.Controls.Add(this._domainTextBox);
			this.Controls.Add(this._passwordLabel);
			this.Controls.Add(this._passwordTextBox);
			this.Controls.Add(this._userNameTextBox);
			this.Controls.Add(this._usernameLabel);
			this.Controls.Add(this._errorGroupBox);
			this.Controls.Add(this._serverSampleLabel);
			this.Controls.Add(this._serverLabel);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._connectButton);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectToWebServerForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to a web server";
			this._errorGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _connectButton;
		private System.Windows.Forms.Label _serverLabel;
		private System.Windows.Forms.Label _serverSampleLabel;
		private System.Windows.Forms.GroupBox _errorGroupBox;
		private System.Windows.Forms.Label _errorMessageLabel;
		private System.Windows.Forms.Label _usernameLabel;
		private System.Windows.Forms.TextBox _userNameTextBox;
		private System.Windows.Forms.TextBox _passwordTextBox;
		private System.Windows.Forms.Label _passwordLabel;
		private System.Windows.Forms.TextBox _domainTextBox;
		private System.Windows.Forms.Label _domainLabel;
		private System.Windows.Forms.Label _credentialsInfoLabel;
		private System.Windows.Forms.ComboBox _urlComboBox;
	}
}