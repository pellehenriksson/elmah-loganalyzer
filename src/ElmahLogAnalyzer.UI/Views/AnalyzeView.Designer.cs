namespace ElmahLogAnalyzer.UI.Views
{
	partial class AnalyzeView
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
			this._tabControl = new System.Windows.Forms.TabControl();
			this._searchTabPage = new System.Windows.Forms.TabPage();
			this._reportsTabPage = new System.Windows.Forms.TabPage();
			this._tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tabControl
			// 
			this._tabControl.Controls.Add(this._searchTabPage);
			this._tabControl.Controls.Add(this._reportsTabPage);
			this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tabControl.Location = new System.Drawing.Point(0, 0);
			this._tabControl.Name = "_tabControl";
			this._tabControl.SelectedIndex = 0;
			this._tabControl.Size = new System.Drawing.Size(973, 628);
			this._tabControl.TabIndex = 0;
			// 
			// _searchTabPage
			// 
			this._searchTabPage.Location = new System.Drawing.Point(4, 22);
			this._searchTabPage.Name = "_searchTabPage";
			this._searchTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._searchTabPage.Size = new System.Drawing.Size(965, 602);
			this._searchTabPage.TabIndex = 0;
			this._searchTabPage.Text = "Search";
			this._searchTabPage.UseVisualStyleBackColor = true;
			// 
			// _reportsTabPage
			// 
			this._reportsTabPage.Location = new System.Drawing.Point(4, 22);
			this._reportsTabPage.Name = "_reportsTabPage";
			this._reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._reportsTabPage.Size = new System.Drawing.Size(965, 602);
			this._reportsTabPage.TabIndex = 1;
			this._reportsTabPage.Text = "Reports";
			this._reportsTabPage.UseVisualStyleBackColor = true;
			// 
			// AnalyzeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._tabControl);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "AnalyzeView";
			this.Size = new System.Drawing.Size(973, 628);
			this._tabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl _tabControl;
		private System.Windows.Forms.TabPage _searchTabPage;
		private System.Windows.Forms.TabPage _reportsTabPage;
	}
}
