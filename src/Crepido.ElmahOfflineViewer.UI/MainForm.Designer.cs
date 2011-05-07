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
			this.showSearchViewButton = new System.Windows.Forms.ToolStripButton();
			this.showReportViewButton = new System.Windows.Forms.ToolStripButton();
			this.selectDirectoryButton = new System.Windows.Forms.ToolStripButton();
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
			this._mainStatusStrip.Size = new System.Drawing.Size(1264, 24);
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
			this.directoryToolStripStatusLabel.Size = new System.Drawing.Size(1191, 19);
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
            this.showSearchViewButton,
            this.showReportViewButton,
            this.selectDirectoryButton});
			this._mainToolStrip.Location = new System.Drawing.Point(0, 0);
			this._mainToolStrip.Name = "_mainToolStrip";
			this._mainToolStrip.Size = new System.Drawing.Size(1264, 25);
			this._mainToolStrip.TabIndex = 1;
			this._mainToolStrip.Text = "toolStrip1";
			// 
			// showSearchViewButton
			// 
			this.showSearchViewButton.Image = ((System.Drawing.Image)(resources.GetObject("showSearchViewButton.Image")));
			this.showSearchViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.showSearchViewButton.Name = "showSearchViewButton";
			this.showSearchViewButton.Size = new System.Drawing.Size(62, 22);
			this.showSearchViewButton.Text = "Search";
			this.showSearchViewButton.Click += new System.EventHandler(this.ShowSearchViewButtonClick);
			// 
			// showReportViewButton
			// 
			this.showReportViewButton.Image = ((System.Drawing.Image)(resources.GetObject("showReportViewButton.Image")));
			this.showReportViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.showReportViewButton.Name = "showReportViewButton";
			this.showReportViewButton.Size = new System.Drawing.Size(67, 22);
			this.showReportViewButton.Text = "Reports";
			this.showReportViewButton.Click += new System.EventHandler(this.ShowReportViewButtonClick);
			// 
			// selectDirectoryButton
			// 
			this.selectDirectoryButton.Image = global::Crepido.ElmahOfflineViewer.UI.Properties.Resources.folder_bug;
			this.selectDirectoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.selectDirectoryButton.Name = "selectDirectoryButton";
			this.selectDirectoryButton.Size = new System.Drawing.Size(108, 22);
			this.selectDirectoryButton.Text = "Select directory";
			this.selectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButtonClick);
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
			this.mainPanel.Size = new System.Drawing.Size(1264, 679);
			this.mainPanel.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 728);
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
		private System.Windows.Forms.ToolStripButton selectDirectoryButton;
		private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
		private System.Windows.Forms.ToolStripStatusLabel versionStripStatusLabel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.ToolStripButton showSearchViewButton;
		private System.Windows.Forms.ToolStripButton showReportViewButton;

		private void RepositoryOnInitialized(object sender, Core.Domain.RepositoryInitializedEventArgs e)
		{
			directoryToolStripStatusLabel.Text = string.Format("Directory : {0} Logs found: {1}", e.Directory, e.TotalNumberOfLogs);
		}
	}
}