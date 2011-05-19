namespace Crepido.ElmahOfflineViewer.UI.Views
{
	partial class LoadingView
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
			this._loadingPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._loadingPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// _loadingPictureBox
			// 
			this._loadingPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._loadingPictureBox.ErrorImage = null;
			this._loadingPictureBox.Image = global::Crepido.ElmahOfflineViewer.UI.Properties.Resources.loading;
			this._loadingPictureBox.Location = new System.Drawing.Point(0, 0);
			this._loadingPictureBox.Name = "_loadingPictureBox";
			this._loadingPictureBox.Size = new System.Drawing.Size(618, 348);
			this._loadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this._loadingPictureBox.TabIndex = 0;
			this._loadingPictureBox.TabStop = false;
			// 
			// LoadingView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._loadingPictureBox);
			this.Name = "LoadingView";
			this.Size = new System.Drawing.Size(618, 348);
			((System.ComponentModel.ISupportInitialize)(this._loadingPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox _loadingPictureBox;

	}
}
