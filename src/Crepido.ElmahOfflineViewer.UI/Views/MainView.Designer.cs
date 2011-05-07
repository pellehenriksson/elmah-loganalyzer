namespace Crepido.ElmahOfflineViewer.UI.Views
{
	partial class MainView
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this._searchTabPage = new System.Windows.Forms.TabPage();
			this._reportTabPage = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this._searchTabPage);
			this.tabControl1.Controls.Add(this._reportTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(836, 561);
			this.tabControl1.TabIndex = 0;
			// 
			// _searchTabPage
			// 
			this._searchTabPage.Location = new System.Drawing.Point(4, 22);
			this._searchTabPage.Name = "_searchTabPage";
			this._searchTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._searchTabPage.Size = new System.Drawing.Size(828, 535);
			this._searchTabPage.TabIndex = 0;
			this._searchTabPage.Text = "Search";
			this._searchTabPage.UseVisualStyleBackColor = true;
			// 
			// _reportTabPage
			// 
			this._reportTabPage.Location = new System.Drawing.Point(4, 22);
			this._reportTabPage.Name = "_reportTabPage";
			this._reportTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._reportTabPage.Size = new System.Drawing.Size(828, 535);
			this._reportTabPage.TabIndex = 1;
			this._reportTabPage.Text = "Reports";
			this._reportTabPage.UseVisualStyleBackColor = true;
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(836, 561);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage _searchTabPage;
		private System.Windows.Forms.TabPage _reportTabPage;
	}
}
