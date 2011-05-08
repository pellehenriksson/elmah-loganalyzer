namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	partial class SearchErrorDetailsView
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
			this.errorTabPage = new System.Windows.Forms.TabPage();
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
			this.clientTabPage = new System.Windows.Forms.TabPage();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.formsTabPage = new System.Windows.Forms.TabPage();
			this._formsListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cookiesTabPage = new System.Windows.Forms.TabPage();
			this._cookiesListView = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.queryStringTabPage = new System.Windows.Forms.TabPage();
			this._querystringListView = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.serverVariablesTabPage = new System.Windows.Forms.TabPage();
			this._servervariablesListView = new System.Windows.Forms.ListView();
			this._nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._timeLabel = new System.Windows.Forms.TextBox();
			this._urlLabel = new System.Windows.Forms.TextBox();
			this._typeLabel = new System.Windows.Forms.TextBox();
			this._sourceLabel = new System.Windows.Forms.TextBox();
			this._userLabel = new System.Windows.Forms.TextBox();
			this._browserLabel = new System.Windows.Forms.TextBox();
			this._operatingSystemLabel = new System.Windows.Forms.TextBox();
			this._platformLabel = new System.Windows.Forms.TextBox();
			this._ipAddressLabel = new System.Windows.Forms.TextBox();
			this._detailsTabControl.SuspendLayout();
			this.errorTabPage.SuspendLayout();
			this._errorTabControl.SuspendLayout();
			this._messageTabPage.SuspendLayout();
			this._detailsTabPage.SuspendLayout();
			this._yellowScreenOfDeathTabPage.SuspendLayout();
			this.clientTabPage.SuspendLayout();
			this.formsTabPage.SuspendLayout();
			this.cookiesTabPage.SuspendLayout();
			this.queryStringTabPage.SuspendLayout();
			this.serverVariablesTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// _detailsTabControl
			// 
			this._detailsTabControl.Controls.Add(this.errorTabPage);
			this._detailsTabControl.Controls.Add(this.clientTabPage);
			this._detailsTabControl.Controls.Add(this.formsTabPage);
			this._detailsTabControl.Controls.Add(this.cookiesTabPage);
			this._detailsTabControl.Controls.Add(this.queryStringTabPage);
			this._detailsTabControl.Controls.Add(this.serverVariablesTabPage);
			this._detailsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._detailsTabControl.Location = new System.Drawing.Point(0, 0);
			this._detailsTabControl.Name = "_detailsTabControl";
			this._detailsTabControl.SelectedIndex = 0;
			this._detailsTabControl.Size = new System.Drawing.Size(612, 386);
			this._detailsTabControl.TabIndex = 0;
			// 
			// errorTabPage
			// 
			this.errorTabPage.BackColor = System.Drawing.Color.White;
			this.errorTabPage.Controls.Add(this._sourceLabel);
			this.errorTabPage.Controls.Add(this._typeLabel);
			this.errorTabPage.Controls.Add(this._urlLabel);
			this.errorTabPage.Controls.Add(this._timeLabel);
			this.errorTabPage.Controls.Add(this.label6);
			this.errorTabPage.Controls.Add(this._errorTabControl);
			this.errorTabPage.Controls.Add(this.label2);
			this.errorTabPage.Controls.Add(this.label5);
			this.errorTabPage.Controls.Add(this.label3);
			this.errorTabPage.Location = new System.Drawing.Point(4, 22);
			this.errorTabPage.Name = "errorTabPage";
			this.errorTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.errorTabPage.Size = new System.Drawing.Size(604, 360);
			this.errorTabPage.TabIndex = 0;
			this.errorTabPage.Text = "Error";
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
			this._errorTabControl.Size = new System.Drawing.Size(592, 241);
			this._errorTabControl.TabIndex = 8;
			// 
			// _messageTabPage
			// 
			this._messageTabPage.Controls.Add(this._messageTextBox);
			this._messageTabPage.Location = new System.Drawing.Point(4, 22);
			this._messageTabPage.Name = "_messageTabPage";
			this._messageTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._messageTabPage.Size = new System.Drawing.Size(584, 215);
			this._messageTabPage.TabIndex = 0;
			this._messageTabPage.Text = "Message";
			this._messageTabPage.UseVisualStyleBackColor = true;
			// 
			// _messageTextBox
			// 
			this._messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._messageTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._messageTextBox.Location = new System.Drawing.Point(3, 3);
			this._messageTextBox.Multiline = true;
			this._messageTextBox.Name = "_messageTextBox";
			this._messageTextBox.ReadOnly = true;
			this._messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._messageTextBox.Size = new System.Drawing.Size(578, 209);
			this._messageTextBox.TabIndex = 0;
			// 
			// _detailsTabPage
			// 
			this._detailsTabPage.Controls.Add(this._detailsTextBox);
			this._detailsTabPage.Location = new System.Drawing.Point(4, 22);
			this._detailsTabPage.Name = "_detailsTabPage";
			this._detailsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._detailsTabPage.Size = new System.Drawing.Size(584, 215);
			this._detailsTabPage.TabIndex = 1;
			this._detailsTabPage.Text = "Details";
			this._detailsTabPage.UseVisualStyleBackColor = true;
			// 
			// _detailsTextBox
			// 
			this._detailsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._detailsTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._detailsTextBox.Location = new System.Drawing.Point(3, 3);
			this._detailsTextBox.Multiline = true;
			this._detailsTextBox.Name = "_detailsTextBox";
			this._detailsTextBox.ReadOnly = true;
			this._detailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._detailsTextBox.Size = new System.Drawing.Size(578, 209);
			this._detailsTextBox.TabIndex = 0;
			// 
			// _yellowScreenOfDeathTabPage
			// 
			this._yellowScreenOfDeathTabPage.Controls.Add(this._browser);
			this._yellowScreenOfDeathTabPage.Location = new System.Drawing.Point(4, 22);
			this._yellowScreenOfDeathTabPage.Name = "_yellowScreenOfDeathTabPage";
			this._yellowScreenOfDeathTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._yellowScreenOfDeathTabPage.Size = new System.Drawing.Size(584, 215);
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
			this._browser.Size = new System.Drawing.Size(578, 209);
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
			// clientTabPage
			// 
			this.clientTabPage.BackColor = System.Drawing.Color.White;
			this.clientTabPage.Controls.Add(this._ipAddressLabel);
			this.clientTabPage.Controls.Add(this._platformLabel);
			this.clientTabPage.Controls.Add(this._operatingSystemLabel);
			this.clientTabPage.Controls.Add(this._browserLabel);
			this.clientTabPage.Controls.Add(this._userLabel);
			this.clientTabPage.Controls.Add(this.label9);
			this.clientTabPage.Controls.Add(this.label4);
			this.clientTabPage.Controls.Add(this.label12);
			this.clientTabPage.Controls.Add(this.label10);
			this.clientTabPage.Controls.Add(this.label8);
			this.clientTabPage.Location = new System.Drawing.Point(4, 22);
			this.clientTabPage.Name = "clientTabPage";
			this.clientTabPage.Size = new System.Drawing.Size(604, 360);
			this.clientTabPage.TabIndex = 2;
			this.clientTabPage.Text = "Client Information";
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
			// formsTabPage
			// 
			this.formsTabPage.Controls.Add(this._formsListView);
			this.formsTabPage.Location = new System.Drawing.Point(4, 22);
			this.formsTabPage.Name = "formsTabPage";
			this.formsTabPage.Size = new System.Drawing.Size(604, 360);
			this.formsTabPage.TabIndex = 4;
			this.formsTabPage.Text = "Forms";
			this.formsTabPage.UseVisualStyleBackColor = true;
			// 
			// _formsListView
			// 
			this._formsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this._formsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._formsListView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._formsListView.FullRowSelect = true;
			this._formsListView.GridLines = true;
			this._formsListView.Location = new System.Drawing.Point(0, 0);
			this._formsListView.Name = "_formsListView";
			this._formsListView.Size = new System.Drawing.Size(604, 360);
			this._formsListView.TabIndex = 1;
			this._formsListView.UseCompatibleStateImageBehavior = false;
			this._formsListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 134;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Value";
			this.columnHeader2.Width = 438;
			// 
			// cookiesTabPage
			// 
			this.cookiesTabPage.Controls.Add(this._cookiesListView);
			this.cookiesTabPage.Location = new System.Drawing.Point(4, 22);
			this.cookiesTabPage.Name = "cookiesTabPage";
			this.cookiesTabPage.Size = new System.Drawing.Size(604, 360);
			this.cookiesTabPage.TabIndex = 3;
			this.cookiesTabPage.Text = "Cookies";
			this.cookiesTabPage.UseVisualStyleBackColor = true;
			// 
			// _cookiesListView
			// 
			this._cookiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this._cookiesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._cookiesListView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._cookiesListView.FullRowSelect = true;
			this._cookiesListView.GridLines = true;
			this._cookiesListView.Location = new System.Drawing.Point(0, 0);
			this._cookiesListView.Name = "_cookiesListView";
			this._cookiesListView.Size = new System.Drawing.Size(604, 360);
			this._cookiesListView.TabIndex = 1;
			this._cookiesListView.UseCompatibleStateImageBehavior = false;
			this._cookiesListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Name";
			this.columnHeader3.Width = 134;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Value";
			this.columnHeader4.Width = 438;
			// 
			// queryStringTabPage
			// 
			this.queryStringTabPage.Controls.Add(this._querystringListView);
			this.queryStringTabPage.Location = new System.Drawing.Point(4, 22);
			this.queryStringTabPage.Name = "queryStringTabPage";
			this.queryStringTabPage.Size = new System.Drawing.Size(604, 360);
			this.queryStringTabPage.TabIndex = 5;
			this.queryStringTabPage.Text = "Querystring";
			this.queryStringTabPage.UseVisualStyleBackColor = true;
			// 
			// _querystringListView
			// 
			this._querystringListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
			this._querystringListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._querystringListView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._querystringListView.FullRowSelect = true;
			this._querystringListView.GridLines = true;
			this._querystringListView.Location = new System.Drawing.Point(0, 0);
			this._querystringListView.Name = "_querystringListView";
			this._querystringListView.Size = new System.Drawing.Size(604, 360);
			this._querystringListView.TabIndex = 1;
			this._querystringListView.UseCompatibleStateImageBehavior = false;
			this._querystringListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Name";
			this.columnHeader5.Width = 134;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Value";
			this.columnHeader6.Width = 438;
			// 
			// serverVariablesTabPage
			// 
			this.serverVariablesTabPage.Controls.Add(this._servervariablesListView);
			this.serverVariablesTabPage.Location = new System.Drawing.Point(4, 22);
			this.serverVariablesTabPage.Name = "serverVariablesTabPage";
			this.serverVariablesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.serverVariablesTabPage.Size = new System.Drawing.Size(604, 360);
			this.serverVariablesTabPage.TabIndex = 1;
			this.serverVariablesTabPage.Text = "Server Variables";
			this.serverVariablesTabPage.UseVisualStyleBackColor = true;
			// 
			// _servervariablesListView
			// 
			this._servervariablesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._nameColumnHeader,
            this._valueColumnHeader});
			this._servervariablesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._servervariablesListView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._servervariablesListView.FullRowSelect = true;
			this._servervariablesListView.GridLines = true;
			this._servervariablesListView.Location = new System.Drawing.Point(3, 3);
			this._servervariablesListView.Name = "_servervariablesListView";
			this._servervariablesListView.Size = new System.Drawing.Size(598, 354);
			this._servervariablesListView.TabIndex = 0;
			this._servervariablesListView.UseCompatibleStateImageBehavior = false;
			this._servervariablesListView.View = System.Windows.Forms.View.Details;
			// 
			// _nameColumnHeader
			// 
			this._nameColumnHeader.Text = "Name";
			this._nameColumnHeader.Width = 134;
			// 
			// _valueColumnHeader
			// 
			this._valueColumnHeader.Text = "Value";
			this._valueColumnHeader.Width = 438;
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
			// SearchErrorDetailsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._detailsTabControl);
			this.Name = "SearchErrorDetailsView";
			this.Size = new System.Drawing.Size(612, 386);
			this._detailsTabControl.ResumeLayout(false);
			this.errorTabPage.ResumeLayout(false);
			this.errorTabPage.PerformLayout();
			this._errorTabControl.ResumeLayout(false);
			this._messageTabPage.ResumeLayout(false);
			this._messageTabPage.PerformLayout();
			this._detailsTabPage.ResumeLayout(false);
			this._detailsTabPage.PerformLayout();
			this._yellowScreenOfDeathTabPage.ResumeLayout(false);
			this.clientTabPage.ResumeLayout(false);
			this.clientTabPage.PerformLayout();
			this.formsTabPage.ResumeLayout(false);
			this.cookiesTabPage.ResumeLayout(false);
			this.queryStringTabPage.ResumeLayout(false);
			this.serverVariablesTabPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl _detailsTabControl;
		private System.Windows.Forms.TabPage errorTabPage;
		private System.Windows.Forms.TabPage serverVariablesTabPage;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl _errorTabControl;
		private System.Windows.Forms.TabPage _messageTabPage;
		private System.Windows.Forms.TabPage _detailsTabPage;
		private System.Windows.Forms.TextBox _messageTextBox;
		private System.Windows.Forms.TextBox _detailsTextBox;
		private System.Windows.Forms.ListView _servervariablesListView;
		private System.Windows.Forms.ColumnHeader _nameColumnHeader;
		private System.Windows.Forms.ColumnHeader _valueColumnHeader;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage clientTabPage;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage formsTabPage;
		private System.Windows.Forms.TabPage cookiesTabPage;
		private System.Windows.Forms.TabPage queryStringTabPage;
		private System.Windows.Forms.ListView _formsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ListView _cookiesListView;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ListView _querystringListView;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
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
	}
}
