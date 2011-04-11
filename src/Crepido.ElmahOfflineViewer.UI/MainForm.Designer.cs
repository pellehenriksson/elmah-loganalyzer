namespace Crepido.ElmahOfflineViewer.UI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.directoryToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.versionStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this._mainToolStrip = new System.Windows.Forms.ToolStrip();
			this.selectViewButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.searchViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._selectDirectoryButton = new System.Windows.Forms.ToolStripButton();
			this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.mainPanel = new System.Windows.Forms.Panel();
			this._mainStatusStrip.SuspendLayout();
			this._mainToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainStatusStrip
			// 
			this._mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryToolStripStatusLabel,
            this.versionStripStatusLabel});
			this._mainStatusStrip.Location = new System.Drawing.Point(0, 704);
			this._mainStatusStrip.Name = "_mainStatusStrip";
			this._mainStatusStrip.Size = new System.Drawing.Size(1135, 24);
			this._mainStatusStrip.TabIndex = 0;
			this._mainStatusStrip.Text = "statusStrip1";
			// 
			// directoryToolStripStatusLabel
			// 
			this.directoryToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.directoryToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.directoryToolStripStatusLabel.Name = "directoryToolStripStatusLabel";
			this.directoryToolStripStatusLabel.Size = new System.Drawing.Size(1062, 19);
			this.directoryToolStripStatusLabel.Spring = true;
			this.directoryToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// versionStripStatusLabel
			// 
			this.versionStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.versionStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.versionStripStatusLabel.Name = "versionStripStatusLabel";
			this.versionStripStatusLabel.Size = new System.Drawing.Size(58, 19);
			this.versionStripStatusLabel.Text = "[Version]";
			this.versionStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _mainToolStrip
			// 
			this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectViewButton,
            this._selectDirectoryButton});
			this._mainToolStrip.Location = new System.Drawing.Point(0, 0);
			this._mainToolStrip.Name = "_mainToolStrip";
			this._mainToolStrip.Size = new System.Drawing.Size(1135, 25);
			this._mainToolStrip.TabIndex = 1;
			this._mainToolStrip.Text = "toolStrip1";
			// 
			// selectViewButton
			// 
			this.selectViewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchViewMenuItem,
            this.reportsViewMenuItem});
			this.selectViewButton.Image = ((System.Drawing.Image)(resources.GetObject("selectViewButton.Image")));
			this.selectViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.selectViewButton.Name = "selectViewButton";
			this.selectViewButton.Size = new System.Drawing.Size(94, 22);
			this.selectViewButton.Text = "Select view";
			// 
			// searchViewMenuItem
			// 
			this.searchViewMenuItem.Name = "searchViewMenuItem";
			this.searchViewMenuItem.Size = new System.Drawing.Size(114, 22);
			this.searchViewMenuItem.Text = "Search";
			this.searchViewMenuItem.Click += new System.EventHandler(this.SearchViewMenuItemClick);
			// 
			// reportsViewMenuItem
			// 
			this.reportsViewMenuItem.Name = "reportsViewMenuItem";
			this.reportsViewMenuItem.Size = new System.Drawing.Size(114, 22);
			this.reportsViewMenuItem.Text = "Reports";
			this.reportsViewMenuItem.Click += new System.EventHandler(this.ReportsViewMenuItemClick);
			// 
			// _selectDirectoryButton
			// 
			this._selectDirectoryButton.Image = global::Crepido.ElmahOfflineViewer.UI.Properties.Resources.folder_bug;
			this._selectDirectoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._selectDirectoryButton.Name = "_selectDirectoryButton";
			this._selectDirectoryButton.Size = new System.Drawing.Size(108, 22);
			this._selectDirectoryButton.Text = "Select directory";
			this._selectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButtonClick);
			// 
			// _folderBrowserDialog
			// 
			this._folderBrowserDialog.Description = "Select a folder with ELMAH log files";
			this._folderBrowserDialog.ShowNewFolderButton = false;
			// 
			// mainPanel
			// 
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 25);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1135, 679);
			this.mainPanel.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1135, 728);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this._mainToolStrip);
			this.Controls.Add(this._mainStatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Crepido ELMAH Offline Viewer";
			this._mainStatusStrip.ResumeLayout(false);
			this._mainStatusStrip.PerformLayout();
			this._mainToolStrip.ResumeLayout(false);
			this._mainToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip _mainStatusStrip;
		private System.Windows.Forms.ToolStrip _mainToolStrip;
		private System.Windows.Forms.ToolStripStatusLabel directoryToolStripStatusLabel;
		private System.Windows.Forms.ToolStripButton _selectDirectoryButton;
		private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
		private System.Windows.Forms.ToolStripStatusLabel versionStripStatusLabel;
		private System.Windows.Forms.ToolStripDropDownButton selectViewButton;
		private System.Windows.Forms.ToolStripMenuItem searchViewMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportsViewMenuItem;
		private System.Windows.Forms.Panel mainPanel;
	}
}