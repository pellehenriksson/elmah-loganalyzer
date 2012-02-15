namespace ElmahLogAnalyzer.UI.Views.Partials
{
	partial class ConnectToSqlServerView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._useIntegratedSecurityCheckBox = new System.Windows.Forms.CheckBox();
			this._passwordLabel = new System.Windows.Forms.Label();
			this._usernameLabel = new System.Windows.Forms.Label();
			this._databaseLabel = new System.Windows.Forms.Label();
			this._passwordTextBox = new System.Windows.Forms.TextBox();
			this._usernameTextBox = new System.Windows.Forms.TextBox();
			this._databaseTextBox = new System.Windows.Forms.TextBox();
			this._serverTextBox = new System.Windows.Forms.TextBox();
			this._serverLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _useIntegratedSecurityCheckBox
			// 
			this._useIntegratedSecurityCheckBox.AutoSize = true;
			this._useIntegratedSecurityCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._useIntegratedSecurityCheckBox.Location = new System.Drawing.Point(77, 65);
			this._useIntegratedSecurityCheckBox.Name = "_useIntegratedSecurityCheckBox";
			this._useIntegratedSecurityCheckBox.Size = new System.Drawing.Size(138, 17);
			this._useIntegratedSecurityCheckBox.TabIndex = 13;
			this._useIntegratedSecurityCheckBox.Text = "Use integrated security";
			this._useIntegratedSecurityCheckBox.UseVisualStyleBackColor = true;
			this._useIntegratedSecurityCheckBox.CheckedChanged += new System.EventHandler(this.UseIntegratedSecurityCheckBoxCheckedChanged);
			// 
			// _passwordLabel
			// 
			this._passwordLabel.AutoSize = true;
			this._passwordLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._passwordLabel.Location = new System.Drawing.Point(1, 115);
			this._passwordLabel.Name = "_passwordLabel";
			this._passwordLabel.Size = new System.Drawing.Size(57, 13);
			this._passwordLabel.TabIndex = 16;
			this._passwordLabel.Text = "Password:";
			// 
			// _usernameLabel
			// 
			this._usernameLabel.AutoSize = true;
			this._usernameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._usernameLabel.Location = new System.Drawing.Point(1, 88);
			this._usernameLabel.Name = "_usernameLabel";
			this._usernameLabel.Size = new System.Drawing.Size(62, 13);
			this._usernameLabel.TabIndex = 14;
			this._usernameLabel.Text = "User name:";
			// 
			// _databaseLabel
			// 
			this._databaseLabel.AutoSize = true;
			this._databaseLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._databaseLabel.Location = new System.Drawing.Point(1, 28);
			this._databaseLabel.Name = "_databaseLabel";
			this._databaseLabel.Size = new System.Drawing.Size(57, 13);
			this._databaseLabel.TabIndex = 11;
			this._databaseLabel.Text = "Database:";
			// 
			// _passwordTextBox
			// 
			this._passwordTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._passwordTextBox.Location = new System.Drawing.Point(77, 115);
			this._passwordTextBox.Name = "_passwordTextBox";
			this._passwordTextBox.PasswordChar = '*';
			this._passwordTextBox.Size = new System.Drawing.Size(196, 21);
			this._passwordTextBox.TabIndex = 17;
			// 
			// _usernameTextBox
			// 
			this._usernameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._usernameTextBox.Location = new System.Drawing.Point(77, 88);
			this._usernameTextBox.Name = "_usernameTextBox";
			this._usernameTextBox.Size = new System.Drawing.Size(196, 21);
			this._usernameTextBox.TabIndex = 15;
			// 
			// _databaseTextBox
			// 
			this._databaseTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._databaseTextBox.Location = new System.Drawing.Point(77, 28);
			this._databaseTextBox.Name = "_databaseTextBox";
			this._databaseTextBox.Size = new System.Drawing.Size(315, 21);
			this._databaseTextBox.TabIndex = 12;
			// 
			// _serverTextBox
			// 
			this._serverTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverTextBox.Location = new System.Drawing.Point(77, 1);
			this._serverTextBox.Name = "_serverTextBox";
			this._serverTextBox.Size = new System.Drawing.Size(315, 21);
			this._serverTextBox.TabIndex = 10;
			// 
			// _serverLabel
			// 
			this._serverLabel.AutoSize = true;
			this._serverLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverLabel.Location = new System.Drawing.Point(0, 1);
			this._serverLabel.Name = "_serverLabel";
			this._serverLabel.Size = new System.Drawing.Size(43, 13);
			this._serverLabel.TabIndex = 9;
			this._serverLabel.Text = "Server:";
			// 
			// ConnectToSqlServerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._useIntegratedSecurityCheckBox);
			this.Controls.Add(this._passwordLabel);
			this.Controls.Add(this._usernameLabel);
			this.Controls.Add(this._databaseLabel);
			this.Controls.Add(this._passwordTextBox);
			this.Controls.Add(this._usernameTextBox);
			this.Controls.Add(this._databaseTextBox);
			this.Controls.Add(this._serverTextBox);
			this.Controls.Add(this._serverLabel);
			this.Name = "ConnectToSqlServerView";
			this.Size = new System.Drawing.Size(442, 144);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox _useIntegratedSecurityCheckBox;
		private System.Windows.Forms.Label _passwordLabel;
		private System.Windows.Forms.Label _usernameLabel;
		private System.Windows.Forms.Label _databaseLabel;
		private System.Windows.Forms.TextBox _passwordTextBox;
		private System.Windows.Forms.TextBox _usernameTextBox;
		private System.Windows.Forms.TextBox _databaseTextBox;
		private System.Windows.Forms.TextBox _serverTextBox;
		private System.Windows.Forms.Label _serverLabel;
	}
}
