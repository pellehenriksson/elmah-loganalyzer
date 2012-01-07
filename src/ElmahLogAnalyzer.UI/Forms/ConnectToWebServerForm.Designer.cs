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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._errorGroupBox = new System.Windows.Forms.GroupBox();
			this._errorMessageLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._userNameTextBox = new System.Windows.Forms.TextBox();
			this._passwordTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._domainTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._urlComboBox = new System.Windows.Forms.ComboBox();
			this._errorGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this._connectButton.Location = new System.Drawing.Point(333, 226);
			this._connectButton.Name = "_connectButton";
			this._connectButton.Size = new System.Drawing.Size(75, 23);
			this._connectButton.TabIndex = 10;
			this._connectButton.Text = "Connect";
			this._connectButton.UseVisualStyleBackColor = true;
			this._connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server url:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(218, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Example: http://www.myapp.com/elmah.axd";
			// 
			// _errorGroupBox
			// 
			this._errorGroupBox.Controls.Add(this._errorMessageLabel);
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
			this._errorMessageLabel.Location = new System.Drawing.Point(3, 16);
			this._errorMessageLabel.Name = "_errorMessageLabel";
			this._errorMessageLabel.Size = new System.Drawing.Size(394, 47);
			this._errorMessageLabel.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "User name:";
			// 
			// _userNameTextBox
			// 
			this._userNameTextBox.Location = new System.Drawing.Point(89, 75);
			this._userNameTextBox.Name = "_userNameTextBox";
			this._userNameTextBox.Size = new System.Drawing.Size(259, 20);
			this._userNameTextBox.TabIndex = 4;
			// 
			// _passwordTextBox
			// 
			this._passwordTextBox.Location = new System.Drawing.Point(89, 101);
			this._passwordTextBox.Name = "_passwordTextBox";
			this._passwordTextBox.PasswordChar = '*';
			this._passwordTextBox.Size = new System.Drawing.Size(259, 20);
			this._passwordTextBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Password:";
			// 
			// _domainTextBox
			// 
			this._domainTextBox.Location = new System.Drawing.Point(89, 127);
			this._domainTextBox.Name = "_domainTextBox";
			this._domainTextBox.Size = new System.Drawing.Size(259, 20);
			this._domainTextBox.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Domain:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(358, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 46);
			this.label6.TabIndex = 12;
			this.label6.Text = "Not required unless you need to supply Windows credentials to the server.";
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
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._domainTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._passwordTextBox);
			this.Controls.Add(this._userNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._errorGroupBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._connectButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectToWebServerForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to web server";
			this._errorGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _connectButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox _errorGroupBox;
		private System.Windows.Forms.Label _errorMessageLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _userNameTextBox;
		private System.Windows.Forms.TextBox _passwordTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _domainTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox _urlComboBox;
	}
}