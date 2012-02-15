namespace ElmahLogAnalyzer.UI.Forms
{
	partial class ConnectToDatabaseViewForm
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
			this._databaseTypesComboBox = new System.Windows.Forms.ComboBox();
			this._viewPanel = new System.Windows.Forms.Panel();
			this._selectDatabaseTypeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._cancelButton.Location = new System.Drawing.Point(385, 247);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 10;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// _connectButton
			// 
			this._connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._connectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._connectButton.Location = new System.Drawing.Point(304, 247);
			this._connectButton.Name = "_connectButton";
			this._connectButton.Size = new System.Drawing.Size(75, 23);
			this._connectButton.TabIndex = 9;
			this._connectButton.Text = "Connect";
			this._connectButton.UseVisualStyleBackColor = true;
			this._connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
			// 
			// _databaseTypesComboBox
			// 
			this._databaseTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._databaseTypesComboBox.FormattingEnabled = true;
			this._databaseTypesComboBox.Location = new System.Drawing.Point(106, 12);
			this._databaseTypesComboBox.Name = "_databaseTypesComboBox";
			this._databaseTypesComboBox.Size = new System.Drawing.Size(354, 21);
			this._databaseTypesComboBox.TabIndex = 11;
			this._databaseTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.DatabaseTypesComboBoxSelectedIndexChanged);
			// 
			// _viewPanel
			// 
			this._viewPanel.Location = new System.Drawing.Point(12, 65);
			this._viewPanel.Name = "_viewPanel";
			this._viewPanel.Size = new System.Drawing.Size(448, 172);
			this._viewPanel.TabIndex = 12;
			// 
			// _selectDatabaseTypeLabel
			// 
			this._selectDatabaseTypeLabel.AutoSize = true;
			this._selectDatabaseTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._selectDatabaseTypeLabel.Location = new System.Drawing.Point(12, 12);
			this._selectDatabaseTypeLabel.Name = "_selectDatabaseTypeLabel";
			this._selectDatabaseTypeLabel.Size = new System.Drawing.Size(88, 13);
			this._selectDatabaseTypeLabel.TabIndex = 13;
			this._selectDatabaseTypeLabel.Text = "Select database:";
			// 
			// ConnectToDatabaseViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 282);
			this.Controls.Add(this._selectDatabaseTypeLabel);
			this.Controls.Add(this._viewPanel);
			this.Controls.Add(this._databaseTypesComboBox);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._connectButton);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectToDatabaseViewForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to a database";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _connectButton;
		private System.Windows.Forms.ComboBox _databaseTypesComboBox;
		private System.Windows.Forms.Panel _viewPanel;
		private System.Windows.Forms.Label _selectDatabaseTypeLabel;
	}
}