namespace ElmahLogAnalyzer.UI.Forms
{
	partial class ConnectToSqlServerForm
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
			this._useIntegratedSecurityCheckBox = new System.Windows.Forms.CheckBox();
			this._passwordLabel = new System.Windows.Forms.Label();
			this._usernameLabel = new System.Windows.Forms.Label();
			this._databaseLabel = new System.Windows.Forms.Label();
			this._passwordTextBox = new System.Windows.Forms.TextBox();
			this._usernameTextBox = new System.Windows.Forms.TextBox();
			this._databaseTextBox = new System.Windows.Forms.TextBox();
			this._serverTextBox = new System.Windows.Forms.TextBox();
			this._serverLabel = new System.Windows.Forms.Label();
			this._errorGroupBox = new System.Windows.Forms.GroupBox();
			this._errorMessageLabel = new System.Windows.Forms.Label();
			this._errorGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._cancelButton.Location = new System.Drawing.Point(328, 304);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 13;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			// 
			// _connectButton
			// 
			this._connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._connectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._connectButton.Location = new System.Drawing.Point(247, 304);
			this._connectButton.Name = "_connectButton";
			this._connectButton.Size = new System.Drawing.Size(75, 23);
			this._connectButton.TabIndex = 12;
			this._connectButton.Text = "Connect";
			this._connectButton.UseVisualStyleBackColor = true;
			// 
			// _useIntegratedSecurityCheckBox
			// 
			this._useIntegratedSecurityCheckBox.AutoSize = true;
			this._useIntegratedSecurityCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._useIntegratedSecurityCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._useIntegratedSecurityCheckBox.Location = new System.Drawing.Point(91, 115);
			this._useIntegratedSecurityCheckBox.Name = "_useIntegratedSecurityCheckBox";
			this._useIntegratedSecurityCheckBox.Size = new System.Drawing.Size(144, 18);
			this._useIntegratedSecurityCheckBox.TabIndex = 22;
			this._useIntegratedSecurityCheckBox.Text = "Use integrated security";
			this._useIntegratedSecurityCheckBox.UseVisualStyleBackColor = true;
			// 
			// _passwordLabel
			// 
			this._passwordLabel.AutoSize = true;
			this._passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._passwordLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._passwordLabel.Location = new System.Drawing.Point(15, 165);
			this._passwordLabel.Name = "_passwordLabel";
			this._passwordLabel.Size = new System.Drawing.Size(57, 13);
			this._passwordLabel.TabIndex = 25;
			this._passwordLabel.Text = "Password:";
			// 
			// _usernameLabel
			// 
			this._usernameLabel.AutoSize = true;
			this._usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._usernameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._usernameLabel.Location = new System.Drawing.Point(15, 138);
			this._usernameLabel.Name = "_usernameLabel";
			this._usernameLabel.Size = new System.Drawing.Size(62, 13);
			this._usernameLabel.TabIndex = 23;
			this._usernameLabel.Text = "User name:";
			// 
			// _databaseLabel
			// 
			this._databaseLabel.AutoSize = true;
			this._databaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._databaseLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._databaseLabel.Location = new System.Drawing.Point(15, 78);
			this._databaseLabel.Name = "_databaseLabel";
			this._databaseLabel.Size = new System.Drawing.Size(57, 13);
			this._databaseLabel.TabIndex = 20;
			this._databaseLabel.Text = "Database:";
			// 
			// _passwordTextBox
			// 
			this._passwordTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._passwordTextBox.Location = new System.Drawing.Point(91, 165);
			this._passwordTextBox.Name = "_passwordTextBox";
			this._passwordTextBox.PasswordChar = '*';
			this._passwordTextBox.Size = new System.Drawing.Size(196, 21);
			this._passwordTextBox.TabIndex = 26;
			// 
			// _usernameTextBox
			// 
			this._usernameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._usernameTextBox.Location = new System.Drawing.Point(91, 138);
			this._usernameTextBox.Name = "_usernameTextBox";
			this._usernameTextBox.Size = new System.Drawing.Size(196, 21);
			this._usernameTextBox.TabIndex = 24;
			// 
			// _databaseTextBox
			// 
			this._databaseTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._databaseTextBox.Location = new System.Drawing.Point(91, 78);
			this._databaseTextBox.Name = "_databaseTextBox";
			this._databaseTextBox.Size = new System.Drawing.Size(315, 21);
			this._databaseTextBox.TabIndex = 21;
			// 
			// _serverTextBox
			// 
			this._serverTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverTextBox.Location = new System.Drawing.Point(91, 51);
			this._serverTextBox.Name = "_serverTextBox";
			this._serverTextBox.Size = new System.Drawing.Size(315, 21);
			this._serverTextBox.TabIndex = 19;
			// 
			// _serverLabel
			// 
			this._serverLabel.AutoSize = true;
			this._serverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._serverLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverLabel.Location = new System.Drawing.Point(15, 51);
			this._serverLabel.Name = "_serverLabel";
			this._serverLabel.Size = new System.Drawing.Size(43, 13);
			this._serverLabel.TabIndex = 18;
			this._serverLabel.Text = "Server:";
			// 
			// _errorGroupBox
			// 
			this._errorGroupBox.Controls.Add(this._errorMessageLabel);
			this._errorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._errorGroupBox.Location = new System.Drawing.Point(91, 192);
			this._errorGroupBox.Name = "_errorGroupBox";
			this._errorGroupBox.Size = new System.Drawing.Size(315, 100);
			this._errorGroupBox.TabIndex = 27;
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
			// ConnectToSqlServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 339);
			this.Controls.Add(this._errorGroupBox);
			this.Controls.Add(this._useIntegratedSecurityCheckBox);
			this.Controls.Add(this._passwordLabel);
			this.Controls.Add(this._usernameLabel);
			this.Controls.Add(this._databaseLabel);
			this.Controls.Add(this._passwordTextBox);
			this.Controls.Add(this._usernameTextBox);
			this.Controls.Add(this._databaseTextBox);
			this.Controls.Add(this._serverTextBox);
			this.Controls.Add(this._serverLabel);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._connectButton);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectToSqlServerForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to Microsoft SQL Server";
			this._errorGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _connectButton;
		private System.Windows.Forms.CheckBox _useIntegratedSecurityCheckBox;
		private System.Windows.Forms.Label _passwordLabel;
		private System.Windows.Forms.Label _usernameLabel;
		private System.Windows.Forms.Label _databaseLabel;
		private System.Windows.Forms.TextBox _passwordTextBox;
		private System.Windows.Forms.TextBox _usernameTextBox;
		private System.Windows.Forms.TextBox _databaseTextBox;
		private System.Windows.Forms.TextBox _serverTextBox;
		private System.Windows.Forms.Label _serverLabel;
		private System.Windows.Forms.GroupBox _errorGroupBox;
		private System.Windows.Forms.Label _errorMessageLabel;
	}
}