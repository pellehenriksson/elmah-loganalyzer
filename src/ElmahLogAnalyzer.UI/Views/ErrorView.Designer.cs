namespace ElmahLogAnalyzer.UI.Views
{
	partial class ErrorView
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
			this._messageTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// _messageTextBox
			// 
			this._messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._messageTextBox.Location = new System.Drawing.Point(0, 0);
			this._messageTextBox.Multiline = true;
			this._messageTextBox.Name = "_messageTextBox";
			this._messageTextBox.ReadOnly = true;
			this._messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._messageTextBox.Size = new System.Drawing.Size(721, 459);
			this._messageTextBox.TabIndex = 0;
			// 
			// ErrorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._messageTextBox);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ErrorView";
			this.Size = new System.Drawing.Size(721, 459);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox _messageTextBox;

	}
}
