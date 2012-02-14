namespace ElmahLogAnalyzer.UI.Forms
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
			this._connectToDirectoryButton = new System.Windows.Forms.ToolStripButton();
			this._connectToWebServerButton = new System.Windows.Forms.ToolStripButton();
			this._connectToDatabaseButton = new System.Windows.Forms.ToolStripButton();
			this._showSearchViewButton = new System.Windows.Forms.ToolStripButton();
			this._showReportViewButton = new System.Windows.Forms.ToolStripButton();
			this._showAboutButton = new System.Windows.Forms.ToolStripButton();
			this._showSettingsViewButton = new System.Windows.Forms.ToolStripButton();
			this._showExportButton = new System.Windows.Forms.ToolStripButton();
			this._mainPanel = new System.Windows.Forms.Panel();
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
			this._mainStatusStrip.Location = new System.Drawing.Point(0, 706);
			this._mainStatusStrip.Name = "_mainStatusStrip";
			this._mainStatusStrip.Size = new System.Drawing.Size(1358, 22);
			this._mainStatusStrip.TabIndex = 0;
			// 
			// _directoryToolStripStatusLabel
			// 
			this._directoryToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._directoryToolStripStatusLabel.Name = "_directoryToolStripStatusLabel";
			this._directoryToolStripStatusLabel.Size = new System.Drawing.Size(1239, 17);
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
            this._connectToDirectoryButton,
            this._connectToWebServerButton,
            this._connectToDatabaseButton,
            this._showSearchViewButton,
            this._showReportViewButton,
            this._showAboutButton,
            this._showSettingsViewButton,
            this._showExportButton});
			this._mainToolStrip.Location = new System.Drawing.Point(0, 0);
			this._mainToolStrip.Name = "_mainToolStrip";
			this._mainToolStrip.Size = new System.Drawing.Size(1358, 25);
			this._mainToolStrip.TabIndex = 1;
			// 
			// _connectToDirectoryButton
			// 
			this._connectToDirectoryButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.select_directory;
			this._connectToDirectoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._connectToDirectoryButton.Name = "_connectToDirectoryButton";
			this._connectToDirectoryButton.Size = new System.Drawing.Size(135, 22);
			this._connectToDirectoryButton.Text = "Connect to a &directory";
			// 
			// _connectToWebServerButton
			// 
			this._connectToWebServerButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.server;
			this._connectToWebServerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._connectToWebServerButton.Name = "_connectToWebServerButton";
			this._connectToWebServerButton.Size = new System.Drawing.Size(146, 22);
			this._connectToWebServerButton.Text = "Connect to a &web server";
			// 
			// _connectToDatabaseButton
			// 
			this._connectToDatabaseButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.database;
			this._connectToDatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._connectToDatabaseButton.Name = "_connectToDatabaseButton";
			this._connectToDatabaseButton.Size = new System.Drawing.Size(137, 22);
			this._connectToDatabaseButton.Text = "Connect to a data&base";
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
			this._showAboutButton.Text = "About";
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
			this._mainPanel.Size = new System.Drawing.Size(1358, 681);
			this._mainPanel.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1358, 728);
			this.Controls.Add(this._mainPanel);
			this.Controls.Add(this._mainToolStrip);
			this.Controls.Add(this._mainStatusStrip);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
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
		private System.Windows.Forms.ToolStripButton _connectToDirectoryButton;
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
		private System.Windows.Forms.ToolStripButton _connectToWebServerButton;
		private System.Windows.Forms.ToolStripStatusLabel _settingsStripStatusLabel;
		private System.Windows.Forms.ToolStripButton _showExportButton;
		private System.Windows.Forms.ToolStripButton _connectToDatabaseButton;
	}
}