namespace ElmahLogAnalyzer.UI
{
	partial class Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this._directoryToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._settingsStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._versionStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._mainToolStrip = new System.Windows.Forms.ToolStrip();
            this._connectDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this._connectToDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._connectToWebServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._connectToDatabaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._connectToSqlServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._connectToSqlServerCompactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this._disconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._showSearchViewButton = new System.Windows.Forms.ToolStripButton();
            this._showReportViewButton = new System.Windows.Forms.ToolStripButton();
            this._showAboutButton = new System.Windows.Forms.ToolStripButton();
            this._showSettingsViewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._showExportButton = new System.Windows.Forms.ToolStripButton();
            this._mainPanel = new System.Windows.Forms.Panel();
            this._connectToLatestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mainStatusStrip.SuspendLayout();
            this._mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainStatusStrip
            // 
            this._mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._directoryToolStripStatusLabel,
            this._settingsStripStatusLabel,
            this._versionStripStatusLabel});
            this._mainStatusStrip.Location = new System.Drawing.Point(0, 773);
            this._mainStatusStrip.Name = "_mainStatusStrip";
            this._mainStatusStrip.Size = new System.Drawing.Size(983, 22);
            this._mainStatusStrip.TabIndex = 0;
            // 
            // _directoryToolStripStatusLabel
            // 
            this._directoryToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._directoryToolStripStatusLabel.Name = "_directoryToolStripStatusLabel";
            this._directoryToolStripStatusLabel.Size = new System.Drawing.Size(864, 17);
            this._directoryToolStripStatusLabel.Spring = true;
            this._directoryToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _settingsStripStatusLabel
            // 
            this._settingsStripStatusLabel.Name = "_settingsStripStatusLabel";
            this._settingsStripStatusLabel.Size = new System.Drawing.Size(54, 17);
            this._settingsStripStatusLabel.Text = "[Settings]";
            // 
            // _versionStripStatusLabel
            // 
            this._versionStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._versionStripStatusLabel.Name = "_versionStripStatusLabel";
            this._versionStripStatusLabel.Size = new System.Drawing.Size(50, 17);
            this._versionStripStatusLabel.Text = "[Version]";
            this._versionStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _mainToolStrip
            // 
            this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._connectDropDownButton,
            this.toolStripSeparator1,
            this._showSearchViewButton,
            this._showReportViewButton,
            this._showAboutButton,
            this._showSettingsViewButton,
            this.toolStripSeparator2,
            this._showExportButton});
            this._mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this._mainToolStrip.Name = "_mainToolStrip";
            this._mainToolStrip.Size = new System.Drawing.Size(983, 25);
            this._mainToolStrip.TabIndex = 1;
            // 
            // _connectDropDownButton
            // 
            this._connectDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._connectToDirectoryMenuItem,
            this._connectToLatestMenuItem,
            this._connectToWebServerMenuItem,
            this._connectToDatabaseMenuItem,
            this.toolStripMenuItem1,
            this._disconnectMenuItem,
            this.toolStripMenuItem2,
            this._exitMenuItem});
            this._connectDropDownButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.connect;
            this._connectDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._connectDropDownButton.Name = "_connectDropDownButton";
            this._connectDropDownButton.Size = new System.Drawing.Size(76, 22);
            this._connectDropDownButton.Text = "&Connect";
            this._connectDropDownButton.ToolTipText = "Connect to an error log source";
            // 
            // _connectToDirectoryMenuItem
            // 
            this._connectToDirectoryMenuItem.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.errorlog_folder;
            this._connectToDirectoryMenuItem.Name = "_connectToDirectoryMenuItem";
            this._connectToDirectoryMenuItem.Size = new System.Drawing.Size(152, 22);
            this._connectToDirectoryMenuItem.Text = "&Directory";
            this._connectToDirectoryMenuItem.ToolTipText = "Connect to a directory with log files";
            // 
            // _connectToWebServerMenuItem
            // 
            this._connectToWebServerMenuItem.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.server;
            this._connectToWebServerMenuItem.Name = "_connectToWebServerMenuItem";
            this._connectToWebServerMenuItem.Size = new System.Drawing.Size(152, 22);
            this._connectToWebServerMenuItem.Text = "&Web server";
            this._connectToWebServerMenuItem.ToolTipText = "Connect to a web server";
            // 
            // _connectToDatabaseMenuItem
            // 
            this._connectToDatabaseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._connectToSqlServerMenuItem,
            this._connectToSqlServerCompactMenuItem});
            this._connectToDatabaseMenuItem.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.database;
            this._connectToDatabaseMenuItem.Name = "_connectToDatabaseMenuItem";
            this._connectToDatabaseMenuItem.Size = new System.Drawing.Size(152, 22);
            this._connectToDatabaseMenuItem.Text = "Data&base";
            this._connectToDatabaseMenuItem.ToolTipText = "Connect to a database";
            // 
            // _connectToSqlServerMenuItem
            // 
            this._connectToSqlServerMenuItem.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.sqlserver;
            this._connectToSqlServerMenuItem.Name = "_connectToSqlServerMenuItem";
            this._connectToSqlServerMenuItem.Size = new System.Drawing.Size(239, 22);
            this._connectToSqlServerMenuItem.Text = "Microsoft SQL Server";
            this._connectToSqlServerMenuItem.ToolTipText = "Connect to Microsoft SQL Server";
            // 
            // _connectToSqlServerCompactMenuItem
            // 
            this._connectToSqlServerCompactMenuItem.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.sqlserver;
            this._connectToSqlServerCompactMenuItem.Name = "_connectToSqlServerCompactMenuItem";
            this._connectToSqlServerCompactMenuItem.Size = new System.Drawing.Size(239, 22);
            this._connectToSqlServerCompactMenuItem.Text = "Microsoft SQL Server Compact 4.0";
            this._connectToSqlServerCompactMenuItem.ToolTipText = "Connect to Microsoft SQL Server Compact";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // _disconnectMenuItem
            // 
            this._disconnectMenuItem.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.disconnect;
            this._disconnectMenuItem.Name = "_disconnectMenuItem";
            this._disconnectMenuItem.Size = new System.Drawing.Size(152, 22);
            this._disconnectMenuItem.Text = "Disconnect";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // _exitMenuItem
            // 
            this._exitMenuItem.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.close;
            this._exitMenuItem.Name = "_exitMenuItem";
            this._exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this._exitMenuItem.Text = "Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _showSearchViewButton
            // 
            this._showSearchViewButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.search;
            this._showSearchViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showSearchViewButton.Name = "_showSearchViewButton";
            this._showSearchViewButton.Size = new System.Drawing.Size(60, 22);
            this._showSearchViewButton.Text = "&Search";
            this._showSearchViewButton.ToolTipText = "Search logs";
            // 
            // _showReportViewButton
            // 
            this._showReportViewButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.report;
            this._showReportViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showReportViewButton.Name = "_showReportViewButton";
            this._showReportViewButton.Size = new System.Drawing.Size(65, 22);
            this._showReportViewButton.Text = "&Reports";
            this._showReportViewButton.ToolTipText = "View reports";
            // 
            // _showAboutButton
            // 
            this._showAboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._showAboutButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.about;
            this._showAboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showAboutButton.Name = "_showAboutButton";
            this._showAboutButton.Size = new System.Drawing.Size(56, 22);
            this._showAboutButton.Text = "&About";
            // 
            // _showSettingsViewButton
            // 
            this._showSettingsViewButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._showSettingsViewButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.settings;
            this._showSettingsViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showSettingsViewButton.Name = "_showSettingsViewButton";
            this._showSettingsViewButton.Size = new System.Drawing.Size(66, 22);
            this._showSettingsViewButton.Text = "S&ettings";
            this._showSettingsViewButton.ToolTipText = "Change settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _showExportButton
            // 
            this._showExportButton.Image = ((System.Drawing.Image)(resources.GetObject("_showExportButton.Image")));
            this._showExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showExportButton.Name = "_showExportButton";
            this._showExportButton.Size = new System.Drawing.Size(59, 22);
            this._showExportButton.Text = "E&xport";
            // 
            // _mainPanel
            // 
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(0, 25);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(983, 748);
            this._mainPanel.TabIndex = 2;
            // 
            // _connectToLatestMenuItem
            // 
            this._connectToLatestMenuItem.Name = "_connectToLatestMenuItem";
            this._connectToLatestMenuItem.Size = new System.Drawing.Size(152, 22);
            this._connectToLatestMenuItem.Text = "Latest";
            this._connectToLatestMenuItem.ToolTipText = "The latest directories you have connected to";
            this._connectToLatestMenuItem.Visible = false;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 795);
            this.Controls.Add(this._mainPanel);
            this.Controls.Add(this._mainToolStrip);
            this.Controls.Add(this._mainStatusStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Container";
            this.Text = "ELMAH Log Analyzer";
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
		private System.Windows.Forms.ToolStripStatusLabel _directoryToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel _versionStripStatusLabel;
		private System.Windows.Forms.Panel _mainPanel;
		private System.Windows.Forms.ToolStripButton _showSearchViewButton;
		private System.Windows.Forms.ToolStripButton _showReportViewButton;

		private void ErrorLogRepositoryOnInitialized(object sender, Core.Domain.RepositoryInitializedEventArgs e)
		{
			_directoryToolStripStatusLabel.Text = string.Format("Connection : {0} Logs found: {1}", e.Directory, e.TotalNumberOfLogs);
		}

		private System.Windows.Forms.ToolStripButton _showSettingsViewButton;
		private System.Windows.Forms.ToolStripButton _showAboutButton;
		private System.Windows.Forms.ToolStripStatusLabel _settingsStripStatusLabel;
		private System.Windows.Forms.ToolStripButton _showExportButton;
		private System.Windows.Forms.ToolStripDropDownButton _connectDropDownButton;
		private System.Windows.Forms.ToolStripMenuItem _connectToDirectoryMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _connectToWebServerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _connectToDatabaseMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem _disconnectMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem _exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _connectToSqlServerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _connectToSqlServerCompactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _connectToLatestMenuItem;
	}
}