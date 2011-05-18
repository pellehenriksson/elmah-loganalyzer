namespace Crepido.ElmahOfflineViewer.UI.Forms
{
	partial class SelectServerForm
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
			this._urlTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _cancelButton
			// 
			this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._cancelButton.Location = new System.Drawing.Point(414, 167);
			this._cancelButton.Name = "_cancelButton";
			this._cancelButton.Size = new System.Drawing.Size(75, 23);
			this._cancelButton.TabIndex = 4;
			this._cancelButton.Text = "Cancel";
			this._cancelButton.UseVisualStyleBackColor = true;
			this._cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// _connectButton
			// 
			this._connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._connectButton.Location = new System.Drawing.Point(333, 167);
			this._connectButton.Name = "_connectButton";
			this._connectButton.Size = new System.Drawing.Size(75, 23);
			this._connectButton.TabIndex = 3;
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
			// _urlTextBox
			// 
			this._urlTextBox.Location = new System.Drawing.Point(89, 18);
			this._urlTextBox.Name = "_urlTextBox";
			this._urlTextBox.Size = new System.Drawing.Size(400, 20);
			this._urlTextBox.TabIndex = 1;
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
			// SelectServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 202);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._urlTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._cancelButton);
			this.Controls.Add(this._connectButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectServerForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _cancelButton;
		private System.Windows.Forms.Button _connectButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _urlTextBox;
		private System.Windows.Forms.Label label2;
	}
}