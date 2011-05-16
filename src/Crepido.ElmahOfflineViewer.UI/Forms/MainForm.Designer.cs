namespace Crepido.ElmahOfflineViewer.UI.Forms
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
			this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.directoryToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.versionStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this._mainToolStrip = new System.Windows.Forms.ToolStrip();
			this._selectDirectoryButton = new System.Windows.Forms.ToolStripButton();
			this._showSearchViewButton = new System.Windows.Forms.ToolStripButton();
			this._showReportViewButton = new System.Windows.Forms.ToolStripButton();
			this._showAboutButton = new System.Windows.Forms.ToolStripButton();
			this._showSettingsViewButton = new System.Windows.Forms.ToolStripButton();
			this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._mainPanel = new System.Windows.Forms.Panel();
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
            this._selectDirectoryButton,
            this._showSearchViewButton,
            this._showReportViewButton,
            this._showAboutButton,
            this._showSettingsViewButton});
			this._mainToolStrip.Location = new System.Drawing.Point(0, 0);
			this._mainToolStrip.Name = "_mainToolStrip";
			this._mainToolStrip.Size = new System.Drawing.Size(1264, 25);
			this._mainToolStrip.TabIndex = 1;
			this._mainToolStrip.Text = "toolStrip1";
			// 
			// _selectDirectoryButton
			// 
			this._selectDirectoryButton.Image = global::Crepido.ElmahOfflineViewer.UI.Properties.Resources.select_directory;
			this._selectDirectoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._selectDirectoryButton.Name = "_selectDirectoryButton";
			this._selectDirectoryButton.Size = new System.Drawing.Size(108, 22);
			this._selectDirectoryButton.Text = "Select directory";
			this._selectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButtonClick);
			// 
			// _showSearchViewButton
			// 
			this._showSearchViewButton.Image = global::Crepido.ElmahOfflineViewer.UI.Properties.Resources.search;
			this._showSearchViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._showSearchViewButton.Name = "_showSearchViewButton";
			this._showSearchViewButton.Size = new System.Drawing.Size(62, 22);
			this._showSearchViewButton.Text = "Search";
			this._showSearchViewButton.ToolTipText = "Search logs";
			this._showSearchViewButton.Click += new System.EventHandler(this.ShowSearchViewButtonClick);
			// 
			// _showReportViewButton
			// 
			this._showReportViewButton.Image = global::Crepido.ElmahOfflineViewer.UI.Properties.Resources.report;
			this._showReportViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._showReportViewButton.Name = "_showReportViewButton";
			this._showReportViewButton.Size = new System.Drawing.Size(67, 22);
			this._showReportViewButton.Text = "Reports";
			this._showReportViewButton.ToolTipText = "View reports";
			this._showReportViewButton.Click += new System.EventHandler(this.ShowReportViewButtonClick);
			// 
			// _showAboutButton
			// 
			this._showAboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this._showAboutButton.Image = global::Crepido.ElmahOfflineViewer.UI.Properties.Resources.about;
			this._showAboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._showAboutButton.Name = "_showAboutButton";
			this._showAboutButton.Size = new System.Drawing.Size(60, 22);
			this._showAboutButton.Text = "About";
			this._showAboutButton.Click += new System.EventHandler(this.ShowAboutButtonClick);
			// 
			// _showSettingsViewButton
			// 
			this._showSettingsViewButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this._showSettingsViewButton.Image = global::Crepido.ElmahOfflineViewer.UI.Properties.Resources.settings;
			this._showSettingsViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._showSettingsViewButton.Name = "_showSettingsViewButton";
			this._showSettingsViewButton.Size = new System.Drawing.Size(69, 22);
			this._showSettingsViewButton.Text = "Settings";
			this._showSettingsViewButton.ToolTipText = "Change settings";
			this._showSettingsViewButton.Click += new System.EventHandler(this.ShowSettingsViewButtonClick);
			// 
			// _folderBrowserDialog
			// 
			this._folderBrowserDialog.Description = "Select a folder with ELMAH log files";
			this._folderBrowserDialog.ShowNewFolderButton = false;
			// 
			// _mainPanel
			// 
			this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._mainPanel.Location = new System.Drawing.Point(0, 25);
			this._mainPanel.Name = "_mainPanel";
			this._mainPanel.Size = new System.Drawing.Size(1264, 679);
			this._mainPanel.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 728);
			this.Controls.Add(this._mainPanel);
			this.Controls.Add(this._mainToolStrip);
			this.Controls.Add(this._mainStatusStrip);
			this.Name = "MainForm";
			this.Text = "ELMAH Offline Viewer";
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
		private System.Windows.Forms.Panel _mainPanel;
		private System.Windows.Forms.ToolStripButton _showSearchViewButton;
		private System.Windows.Forms.ToolStripButton _showReportViewButton;

		private void RepositoryOnInitialized(object sender, Core.Domain.RepositoryInitializedEventArgs e)
		{
			directoryToolStripStatusLabel.Text = string.Format("Directory : {0} Logs found: {1}", e.Directory, e.TotalNumberOfLogs);
		}

		private System.Windows.Forms.ToolStripButton _showSettingsViewButton;
		private System.Windows.Forms.ToolStripButton _showAboutButton;
	}
}