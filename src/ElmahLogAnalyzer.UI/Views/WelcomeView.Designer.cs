namespace ElmahLogAnalyzer.UI.Views
{
	partial class WelcomeView
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
			this._welcomeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _welcomeLabel
			// 
			this._welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._welcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._welcomeLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._welcomeLabel.Location = new System.Drawing.Point(66, 151);
			this._welcomeLabel.Name = "_welcomeLabel";
			this._welcomeLabel.Size = new System.Drawing.Size(557, 51);
			this._welcomeLabel.TabIndex = 0;
			this._welcomeLabel.Text = "Connect to a error log source and start analyzing";
			this._welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WelcomeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._welcomeLabel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "WelcomeView";
			this.Size = new System.Drawing.Size(678, 412);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label _welcomeLabel;
	}
}
