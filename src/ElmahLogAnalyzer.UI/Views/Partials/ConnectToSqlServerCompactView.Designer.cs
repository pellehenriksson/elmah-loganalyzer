namespace ElmahLogAnalyzer.UI.Views.Partials
{
	partial class ConnectToSqlServerCompactView
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
			this._fileTextBox = new System.Windows.Forms.TextBox();
			this._serverLabel = new System.Windows.Forms.Label();
			this._browseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _fileTextBox
			// 
			this._fileTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._fileTextBox.Location = new System.Drawing.Point(35, 3);
			this._fileTextBox.Name = "_fileTextBox";
			this._fileTextBox.Size = new System.Drawing.Size(383, 21);
			this._fileTextBox.TabIndex = 12;
			// 
			// _serverLabel
			// 
			this._serverLabel.AutoSize = true;
			this._serverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._serverLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._serverLabel.Location = new System.Drawing.Point(2, 3);
			this._serverLabel.Name = "_serverLabel";
			this._serverLabel.Size = new System.Drawing.Size(27, 13);
			this._serverLabel.TabIndex = 11;
			this._serverLabel.Text = "File:";
			// 
			// _browseButton
			// 
			this._browseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._browseButton.Location = new System.Drawing.Point(423, 1);
			this._browseButton.Name = "_browseButton";
			this._browseButton.Size = new System.Drawing.Size(38, 23);
			this._browseButton.TabIndex = 13;
			this._browseButton.Text = "...";
			this._browseButton.UseVisualStyleBackColor = true;
			this._browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// ConnectToSqlServerCompactView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._browseButton);
			this.Controls.Add(this._fileTextBox);
			this.Controls.Add(this._serverLabel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ConnectToSqlServerCompactView";
			this.Size = new System.Drawing.Size(466, 67);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _fileTextBox;
		private System.Windows.Forms.Label _serverLabel;
		private System.Windows.Forms.Button _browseButton;
	}
}
