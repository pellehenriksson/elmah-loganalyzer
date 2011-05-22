namespace ElmahLogAnalyzer.UI.Views.Partials
{
	partial class SearchDetailsView
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
			this._detailsTabControl = new System.Windows.Forms.TabControl();
			this._errorTabPage = new System.Windows.Forms.TabPage();
			this._sourceLabel = new System.Windows.Forms.TextBox();
			this._typeLabel = new System.Windows.Forms.TextBox();
			this._urlLabel = new System.Windows.Forms.TextBox();
			this._timeLabel = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this._errorTabControl = new System.Windows.Forms.TabControl();
			this._messageTabPage = new System.Windows.Forms.TabPage();
			this._messageTextBox = new System.Windows.Forms.TextBox();
			this._detailsTabPage = new System.Windows.Forms.TabPage();
			this._detailsTextBox = new System.Windows.Forms.TextBox();
			this._yellowScreenOfDeathTabPage = new System.Windows.Forms.TabPage();
			this._browser = new System.Windows.Forms.WebBrowser();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._clientTabPage = new System.Windows.Forms.TabPage();
			this._httpUserAgentStringButton = new System.Windows.Forms.Button();
			this._descriptionLabel = new System.Windows.Forms.Label();
			this._ipAddressLabel = new System.Windows.Forms.TextBox();
			this._platformLabel = new System.Windows.Forms.TextBox();
			this._operatingSystemLabel = new System.Windows.Forms.TextBox();
			this._browserLabel = new System.Windows.Forms.TextBox();
			this._userLabel = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this._formsTabPage = new System.Windows.Forms.TabPage();
			this._formsListView = new ElmahLogAnalyzer.UI.Controls.NameValuePairListView();
			this._cookiesTabPage = new System.Windows.Forms.TabPage();
			this._cookiesListView = new ElmahLogAnalyzer.UI.Controls.NameValuePairListView();
			this._queryStringTabPage = new System.Windows.Forms.TabPage();
			this._querystringListView = new ElmahLogAnalyzer.UI.Controls.NameValuePairListView();
			this._serverVariablesTabPage = new System.Windows.Forms.TabPage();
			this._serverVariablesListView = new ElmahLogAnalyzer.UI.Controls.NameValuePairListView();
			this._detailsTabControl.SuspendLayout();
			this._errorTabPage.SuspendLayout();
			this._errorTabControl.SuspendLayout();
			this._messageTabPage.SuspendLayout();
			this._detailsTabPage.SuspendLayout();
			this._yellowScreenOfDeathTabPage.SuspendLayout();
			this._clientTabPage.SuspendLayout();
			this._formsTabPage.SuspendLayout();
			this._cookiesTabPage.SuspendLayout();
			this._queryStringTabPage.SuspendLayout();
			this._serverVariablesTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// _detailsTabControl
			// 
			this._detailsTabControl.Controls.Add(this._errorTabPage);
			this._detailsTabControl.Controls.Add(this._clientTabPage);
			this._detailsTabControl.Controls.Add(this._formsTabPage);
			this._detailsTabControl.Controls.Add(this._cookiesTabPage);
			this._detailsTabControl.Controls.Add(this._queryStringTabPage);
			this._detailsTabControl.Controls.Add(this._serverVariablesTabPage);
			this._detailsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._detailsTabControl.Location = new System.Drawing.Point(0, 0);
			this._detailsTabControl.Name = "_detailsTabControl";
			this._detailsTabControl.SelectedIndex = 0;
			this._detailsTabControl.Size = new System.Drawing.Size(680, 431);
			this._detailsTabControl.TabIndex = 0;
			// 
			// _errorTabPage
			// 
			this._errorTabPage.BackColor = System.Drawing.Color.White;
			this._errorTabPage.Controls.Add(this._sourceLabel);
			this._errorTabPage.Controls.Add(this._typeLabel);
			this._errorTabPage.Controls.Add(this._urlLabel);
			this._errorTabPage.Controls.Add(this._timeLabel);
			this._errorTabPage.Controls.Add(this.label6);
			this._errorTabPage.Controls.Add(this._errorTabControl);
			this._errorTabPage.Controls.Add(this.label2);
			this._errorTabPage.Controls.Add(this.label5);
			this._errorTabPage.Controls.Add(this.label3);
			this._errorTabPage.Location = new System.Drawing.Point(4, 22);
			this._errorTabPage.Name = "_errorTabPage";
			this._errorTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._errorTabPage.Size = new System.Drawing.Size(672, 405);
			this._errorTabPage.TabIndex = 0;
			this._errorTabPage.Text = "Error";
			// 
			// _sourceLabel
			// 
			this._sourceLabel.BackColor = System.Drawing.Color.White;
			this._sourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._sourceLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._sourceLabel.Location = new System.Drawing.Point(79, 85);
			this._sourceLabel.Name = "_sourceLabel";
			this._sourceLabel.ReadOnly = true;
			this._sourceLabel.Size = new System.Drawing.Size(512, 13);
			this._sourceLabel.TabIndex = 14;
			this._sourceLabel.TabStop = false;
			this._sourceLabel.Text = "[Source]";
			// 
			// _typeLabel
			// 
			this._typeLabel.BackColor = System.Drawing.Color.White;
			this._typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._typeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._typeLabel.Location = new System.Drawing.Point(79, 61);
			this._typeLabel.Name = "_typeLabel";
			this._typeLabel.ReadOnly = true;
			this._typeLabel.Size = new System.Drawing.Size(512, 13);
			this._typeLabel.TabIndex = 13;
			this._typeLabel.TabStop = false;
			this._typeLabel.Text = "[Type]";
			// 
			// _urlLabel
			// 
			this._urlLabel.BackColor = System.Drawing.Color.White;
			this._urlLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._urlLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._urlLabel.Location = new System.Drawing.Point(79, 37);
			this._urlLabel.Name = "_urlLabel";
			this._urlLabel.ReadOnly = true;
			this._urlLabel.Size = new System.Drawing.Size(512, 13);
			this._urlLabel.TabIndex = 12;
			this._urlLabel.TabStop = false;
			this._urlLabel.Text = "[Url]";
			// 
			// _timeLabel
			// 
			this._timeLabel.BackColor = System.Drawing.Color.White;
			this._timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._timeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._timeLabel.Location = new System.Drawing.Point(79, 15);
			this._timeLabel.Name = "_timeLabel";
			this._timeLabel.ReadOnly = true;
			this._timeLabel.Size = new System.Drawing.Size(298, 13);
			this._timeLabel.TabIndex = 11;
			this._timeLabel.TabStop = false;
			this._timeLabel.Text = "[Time]";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Url:";
			// 
			// _errorTabControl
			// 
			this._errorTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._errorTabControl.Controls.Add(this._messageTabPage);
			this._errorTabControl.Controls.Add(this._detailsTabPage);
			this._errorTabControl.Controls.Add(this._yellowScreenOfDeathTabPage);
			this._errorTabControl.Location = new System.Drawing.Point(6, 113);
			this._errorTabControl.Name = "_errorTabControl";
			this._errorTabControl.SelectedIndex = 0;
			this._errorTabControl.Size = new System.Drawing.Size(660, 286);
			this._errorTabControl.TabIndex = 8;
			// 
			// _messageTabPage
			// 
			this._messageTabPage.Controls.Add(this._messageTextBox);
			this._messageTabPage.Location = new System.Drawing.Point(4, 22);
			this._messageTabPage.Name = "_messageTabPage";
			this._messageTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._messageTabPage.Size = new System.Drawing.Size(652, 260);
			this._messageTabPage.TabIndex = 0;
			this._messageTabPage.Text = "Message";
			this._messageTabPage.UseVisualStyleBackColor = true;
			// 
			// _messageTextBox
			// 
			this._messageTextBox.BackColor = System.Drawing.Color.White;
			this._messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._messageTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._messageTextBox.Location = new System.Drawing.Point(3, 3);
			this._messageTextBox.Multiline = true;
			this._messageTextBox.Name = "_messageTextBox";
			this._messageTextBox.ReadOnly = true;
			this._messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._messageTextBox.Size = new System.Drawing.Size(646, 254);
			this._messageTextBox.TabIndex = 0;
			// 
			// _detailsTabPage
			// 
			this._detailsTabPage.Controls.Add(this._detailsTextBox);
			this._detailsTabPage.Location = new System.Drawing.Point(4, 22);
			this._detailsTabPage.Name = "_detailsTabPage";
			this._detailsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._detailsTabPage.Size = new System.Drawing.Size(652, 260);
			this._detailsTabPage.TabIndex = 1;
			this._detailsTabPage.Text = "Details";
			this._detailsTabPage.UseVisualStyleBackColor = true;
			// 
			// _detailsTextBox
			// 
			this._detailsTextBox.BackColor = System.Drawing.Color.White;
			this._detailsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._detailsTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._detailsTextBox.Location = new System.Drawing.Point(3, 3);
			this._detailsTextBox.Multiline = true;
			this._detailsTextBox.Name = "_detailsTextBox";
			this._detailsTextBox.ReadOnly = true;
			this._detailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._detailsTextBox.Size = new System.Drawing.Size(646, 254);
			this._detailsTextBox.TabIndex = 0;
			// 
			// _yellowScreenOfDeathTabPage
			// 
			this._yellowScreenOfDeathTabPage.Controls.Add(this._browser);
			this._yellowScreenOfDeathTabPage.Location = new System.Drawing.Point(4, 22);
			this._yellowScreenOfDeathTabPage.Name = "_yellowScreenOfDeathTabPage";
			this._yellowScreenOfDeathTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._yellowScreenOfDeathTabPage.Size = new System.Drawing.Size(652, 260);
			this._yellowScreenOfDeathTabPage.TabIndex = 2;
			this._yellowScreenOfDeathTabPage.Text = "Yellow Screen Of Death";
			this._yellowScreenOfDeathTabPage.UseVisualStyleBackColor = true;
			// 
			// _browser
			// 
			this._browser.Dock = System.Windows.Forms.DockStyle.Fill;
			this._browser.Location = new System.Drawing.Point(3, 3);
			this._browser.MinimumSize = new System.Drawing.Size(20, 20);
			this._browser.Name = "_browser";
			this._browser.Size = new System.Drawing.Size(646, 254);
			this._browser.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Source:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Type:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Time:";
			// 
			// _clientTabPage
			// 
			this._clientTabPage.BackColor = System.Drawing.Color.White;
			this._clientTabPage.Controls.Add(this._httpUserAgentStringButton);
			this._clientTabPage.Controls.Add(this._descriptionLabel);
			this._clientTabPage.Controls.Add(this._ipAddressLabel);
			this._clientTabPage.Controls.Add(this._platformLabel);
			this._clientTabPage.Controls.Add(this._operatingSystemLabel);
			this._clientTabPage.Controls.Add(this._browserLabel);
			this._clientTabPage.Controls.Add(this._userLabel);
			this._clientTabPage.Controls.Add(this.label9);
			this._clientTabPage.Controls.Add(this.label4);
			this._clientTabPage.Controls.Add(this.label12);
			this._clientTabPage.Controls.Add(this.label10);
			this._clientTabPage.Controls.Add(this.label8);
			this._clientTabPage.Location = new System.Drawing.Point(4, 22);
			this._clientTabPage.Name = "_clientTabPage";
			this._clientTabPage.Size = new System.Drawing.Size(672, 405);
			this._clientTabPage.TabIndex = 2;
			this._clientTabPage.Text = "Client Information";
			// 
			// _httpUserAgentStringButton
			// 
			this._httpUserAgentStringButton.Location = new System.Drawing.Point(19, 220);
			this._httpUserAgentStringButton.Name = "_httpUserAgentStringButton";
			this._httpUserAgentStringButton.Size = new System.Drawing.Size(392, 23);
			this._httpUserAgentStringButton.TabIndex = 21;
			this._httpUserAgentStringButton.Text = "Find more client information details online (http://www.useragentstring.com)";
			this._httpUserAgentStringButton.UseVisualStyleBackColor = true;
			this._httpUserAgentStringButton.Click += new System.EventHandler(this.HttpUserAgentStringButtonClick);
			// 
			// _descriptionLabel
			// 
			this._descriptionLabel.Location = new System.Drawing.Point(19, 146);
			this._descriptionLabel.Name = "_descriptionLabel";
			this._descriptionLabel.Size = new System.Drawing.Size(632, 61);
			this._descriptionLabel.TabIndex = 19;
			// 
			// _ipAddressLabel
			// 
			this._ipAddressLabel.BackColor = System.Drawing.Color.White;
			this._ipAddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._ipAddressLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._ipAddressLabel.Location = new System.Drawing.Point(137, 110);
			this._ipAddressLabel.Name = "_ipAddressLabel";
			this._ipAddressLabel.ReadOnly = true;
			this._ipAddressLabel.Size = new System.Drawing.Size(452, 13);
			this._ipAddressLabel.TabIndex = 18;
			this._ipAddressLabel.TabStop = false;
			this._ipAddressLabel.Text = "[IP]";
			// 
			// _platformLabel
			// 
			this._platformLabel.BackColor = System.Drawing.Color.White;
			this._platformLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._platformLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._platformLabel.Location = new System.Drawing.Point(137, 86);
			this._platformLabel.Name = "_platformLabel";
			this._platformLabel.ReadOnly = true;
			this._platformLabel.Size = new System.Drawing.Size(452, 13);
			this._platformLabel.TabIndex = 17;
			this._platformLabel.TabStop = false;
			this._platformLabel.Text = "[Platform]";
			// 
			// _operatingSystemLabel
			// 
			this._operatingSystemLabel.BackColor = System.Drawing.Color.White;
			this._operatingSystemLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._operatingSystemLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._operatingSystemLabel.Location = new System.Drawing.Point(137, 60);
			this._operatingSystemLabel.Name = "_operatingSystemLabel";
			this._operatingSystemLabel.ReadOnly = true;
			this._operatingSystemLabel.Size = new System.Drawing.Size(452, 13);
			this._operatingSystemLabel.TabIndex = 16;
			this._operatingSystemLabel.TabStop = false;
			this._operatingSystemLabel.Text = "[Operating System]";
			// 
			// _browserLabel
			// 
			this._browserLabel.BackColor = System.Drawing.Color.White;
			this._browserLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._browserLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._browserLabel.Location = new System.Drawing.Point(137, 38);
			this._browserLabel.Name = "_browserLabel";
			this._browserLabel.ReadOnly = true;
			this._browserLabel.Size = new System.Drawing.Size(452, 13);
			this._browserLabel.TabIndex = 15;
			this._browserLabel.TabStop = false;
			this._browserLabel.Text = "[Browser]";
			// 
			// _userLabel
			// 
			this._userLabel.BackColor = System.Drawing.Color.White;
			this._userLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._userLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._userLabel.Location = new System.Drawing.Point(137, 15);
			this._userLabel.Name = "_userLabel";
			this._userLabel.ReadOnly = true;
			this._userLabel.Size = new System.Drawing.Size(452, 13);
			this._userLabel.TabIndex = 14;
			this._userLabel.TabStop = false;
			this._userLabel.Text = "[User]";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 110);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 13);
			this.label9.TabIndex = 12;
			this.label9.Text = "IP Address:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "User:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(16, 38);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(55, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "Browser:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(16, 60);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(109, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Operating system:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 86);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Platform:";
			// 
			// _formsTabPage
			// 
			this._formsTabPage.Controls.Add(this._formsListView);
			this._formsTabPage.Location = new System.Drawing.Point(4, 22);
			this._formsTabPage.Name = "_formsTabPage";
			this._formsTabPage.Size = new System.Drawing.Size(672, 405);
			this._formsTabPage.TabIndex = 4;
			this._formsTabPage.Text = "Forms";
			this._formsTabPage.UseVisualStyleBackColor = true;
			// 
			// _formsListView
			// 
			this._formsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._formsListView.Location = new System.Drawing.Point(0, 0);
			this._formsListView.Name = "_formsListView";
			this._formsListView.Size = new System.Drawing.Size(672, 405);
			this._formsListView.TabIndex = 0;
			// 
			// _cookiesTabPage
			// 
			this._cookiesTabPage.Controls.Add(this._cookiesListView);
			this._cookiesTabPage.Location = new System.Drawing.Point(4, 22);
			this._cookiesTabPage.Name = "_cookiesTabPage";
			this._cookiesTabPage.Size = new System.Drawing.Size(672, 405);
			this._cookiesTabPage.TabIndex = 3;
			this._cookiesTabPage.Text = "Cookies";
			this._cookiesTabPage.UseVisualStyleBackColor = true;
			// 
			// _cookiesListView
			// 
			this._cookiesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._cookiesListView.Location = new System.Drawing.Point(0, 0);
			this._cookiesListView.Name = "_cookiesListView";
			this._cookiesListView.Size = new System.Drawing.Size(672, 405);
			this._cookiesListView.TabIndex = 0;
			// 
			// _queryStringTabPage
			// 
			this._queryStringTabPage.Controls.Add(this._querystringListView);
			this._queryStringTabPage.Location = new System.Drawing.Point(4, 22);
			this._queryStringTabPage.Name = "_queryStringTabPage";
			this._queryStringTabPage.Size = new System.Drawing.Size(672, 405);
			this._queryStringTabPage.TabIndex = 5;
			this._queryStringTabPage.Text = "Querystring";
			this._queryStringTabPage.UseVisualStyleBackColor = true;
			// 
			// _querystringListView
			// 
			this._querystringListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._querystringListView.Location = new System.Drawing.Point(0, 0);
			this._querystringListView.Name = "_querystringListView";
			this._querystringListView.Size = new System.Drawing.Size(672, 405);
			this._querystringListView.TabIndex = 0;
			// 
			// _serverVariablesTabPage
			// 
			this._serverVariablesTabPage.Controls.Add(this._serverVariablesListView);
			this._serverVariablesTabPage.Location = new System.Drawing.Point(4, 22);
			this._serverVariablesTabPage.Name = "_serverVariablesTabPage";
			this._serverVariablesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._serverVariablesTabPage.Size = new System.Drawing.Size(672, 405);
			this._serverVariablesTabPage.TabIndex = 1;
			this._serverVariablesTabPage.Text = "Server Variables";
			this._serverVariablesTabPage.UseVisualStyleBackColor = true;
			// 
			// _serverVariablesListView
			// 
			this._serverVariablesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._serverVariablesListView.Location = new System.Drawing.Point(3, 3);
			this._serverVariablesListView.Name = "_serverVariablesListView";
			this._serverVariablesListView.Size = new System.Drawing.Size(666, 399);
			this._serverVariablesListView.TabIndex = 0;
			// 
			// SearchDetailsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._detailsTabControl);
			this.Name = "SearchDetailsView";
			this.Size = new System.Drawing.Size(680, 431);
			this._detailsTabControl.ResumeLayout(false);
			this._errorTabPage.ResumeLayout(false);
			this._errorTabPage.PerformLayout();
			this._errorTabControl.ResumeLayout(false);
			this._messageTabPage.ResumeLayout(false);
			this._messageTabPage.PerformLayout();
			this._detailsTabPage.ResumeLayout(false);
			this._detailsTabPage.PerformLayout();
			this._yellowScreenOfDeathTabPage.ResumeLayout(false);
			this._clientTabPage.ResumeLayout(false);
			this._clientTabPage.PerformLayout();
			this._formsTabPage.ResumeLayout(false);
			this._cookiesTabPage.ResumeLayout(false);
			this._queryStringTabPage.ResumeLayout(false);
			this._serverVariablesTabPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl _detailsTabControl;
		private System.Windows.Forms.TabPage _errorTabPage;
		private System.Windows.Forms.TabPage _serverVariablesTabPage;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl _errorTabControl;
		private System.Windows.Forms.TabPage _messageTabPage;
		private System.Windows.Forms.TabPage _detailsTabPage;
		private System.Windows.Forms.TextBox _messageTextBox;
		private System.Windows.Forms.TextBox _detailsTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage _clientTabPage;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage _formsTabPage;
		private System.Windows.Forms.TabPage _cookiesTabPage;
		private System.Windows.Forms.TabPage _queryStringTabPage;
		private System.Windows.Forms.TabPage _yellowScreenOfDeathTabPage;
		private System.Windows.Forms.WebBrowser _browser;
		private System.Windows.Forms.TextBox _timeLabel;
		private System.Windows.Forms.TextBox _sourceLabel;
		private System.Windows.Forms.TextBox _typeLabel;
		private System.Windows.Forms.TextBox _urlLabel;
		private System.Windows.Forms.TextBox _ipAddressLabel;
		private System.Windows.Forms.TextBox _platformLabel;
		private System.Windows.Forms.TextBox _operatingSystemLabel;
		private System.Windows.Forms.TextBox _browserLabel;
		private System.Windows.Forms.TextBox _userLabel;
		private Controls.NameValuePairListView _formsListView;
		private Controls.NameValuePairListView _cookiesListView;
		private Controls.NameValuePairListView _querystringListView;
		private Controls.NameValuePairListView _serverVariablesListView;
		private System.Windows.Forms.Label _descriptionLabel;
		private System.Windows.Forms.Button _httpUserAgentStringButton;
	}
}
