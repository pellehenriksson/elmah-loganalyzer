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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this._urlLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._userLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this._messageTabPage = new System.Windows.Forms.TabPage();
			this._messageTextBox = new System.Windows.Forms.TextBox();
			this._detailsTabPage = new System.Windows.Forms.TabPage();
			this._detailsTextBox = new System.Windows.Forms.TextBox();
			this._sourceLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._typeLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._timeLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._hostLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this._servervariablesListView = new System.Windows.Forms.ListView();
			this._nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._detailsTabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this._messageTabPage.SuspendLayout();
			this._detailsTabPage.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _detailsTabControl
			// 
			this._detailsTabControl.Controls.Add(this.tabPage1);
			this._detailsTabControl.Controls.Add(this.tabPage2);
			this._detailsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._detailsTabControl.Location = new System.Drawing.Point(0, 0);
			this._detailsTabControl.Name = "_detailsTabControl";
			this._detailsTabControl.SelectedIndex = 0;
			this._detailsTabControl.Size = new System.Drawing.Size(612, 386);
			this._detailsTabControl.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this._urlLabel);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this._userLabel);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.tabControl1);
			this.tabPage1.Controls.Add(this._sourceLabel);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this._typeLabel);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this._timeLabel);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this._hostLabel);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(604, 360);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Error";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// _urlLabel
			// 
			this._urlLabel.AutoSize = true;
			this._urlLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._urlLabel.Location = new System.Drawing.Point(301, 39);
			this._urlLabel.Name = "_urlLabel";
			this._urlLabel.Size = new System.Drawing.Size(37, 13);
			this._urlLabel.TabIndex = 11;
			this._urlLabel.Text = "[Url]";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(251, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Url:";
			// 
			// _userLabel
			// 
			this._userLabel.AutoSize = true;
			this._userLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._userLabel.Location = new System.Drawing.Point(301, 14);
			this._userLabel.Name = "_userLabel";
			this._userLabel.Size = new System.Drawing.Size(43, 13);
			this._userLabel.TabIndex = 9;
			this._userLabel.Text = "[User]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(251, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "User:";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this._messageTabPage);
			this.tabControl1.Controls.Add(this._detailsTabPage);
			this.tabControl1.Location = new System.Drawing.Point(6, 115);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(592, 239);
			this.tabControl1.TabIndex = 8;
			// 
			// _messageTabPage
			// 
			this._messageTabPage.Controls.Add(this._messageTextBox);
			this._messageTabPage.Location = new System.Drawing.Point(4, 22);
			this._messageTabPage.Name = "_messageTabPage";
			this._messageTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._messageTabPage.Size = new System.Drawing.Size(584, 213);
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
			this._messageTextBox.Size = new System.Drawing.Size(578, 207);
			this._messageTextBox.TabIndex = 0;
			// 
			// _detailsTabPage
			// 
			this._detailsTabPage.Controls.Add(this._detailsTextBox);
			this._detailsTabPage.Location = new System.Drawing.Point(4, 22);
			this._detailsTabPage.Name = "_detailsTabPage";
			this._detailsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._detailsTabPage.Size = new System.Drawing.Size(584, 213);
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
			this._detailsTextBox.Size = new System.Drawing.Size(578, 207);
			this._detailsTextBox.TabIndex = 0;
			// 
			// _sourceLabel
			// 
			this._sourceLabel.AutoSize = true;
			this._sourceLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._sourceLabel.Location = new System.Drawing.Point(64, 85);
			this._sourceLabel.Name = "_sourceLabel";
			this._sourceLabel.Size = new System.Drawing.Size(55, 13);
			this._sourceLabel.TabIndex = 7;
			this._sourceLabel.Text = "[Source]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Source:";
			// 
			// _typeLabel
			// 
			this._typeLabel.AutoSize = true;
			this._typeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._typeLabel.Location = new System.Drawing.Point(64, 61);
			this._typeLabel.Name = "_typeLabel";
			this._typeLabel.Size = new System.Drawing.Size(73, 13);
			this._typeLabel.TabIndex = 5;
			this._typeLabel.Text = "[Exception]";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Type:";
			// 
			// _timeLabel
			// 
			this._timeLabel.AutoSize = true;
			this._timeLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._timeLabel.Location = new System.Drawing.Point(64, 39);
			this._timeLabel.Name = "_timeLabel";
			this._timeLabel.Size = new System.Drawing.Size(43, 13);
			this._timeLabel.TabIndex = 3;
			this._timeLabel.Text = "[Time]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Time:";
			// 
			// _hostLabel
			// 
			this._hostLabel.AutoSize = true;
			this._hostLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._hostLabel.Location = new System.Drawing.Point(65, 14);
			this._hostLabel.Name = "_hostLabel";
			this._hostLabel.Size = new System.Drawing.Size(43, 13);
			this._hostLabel.TabIndex = 1;
			this._hostLabel.Text = "[Host]";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Host:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this._servervariablesListView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(604, 360);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Server Variables";
			this.tabPage2.UseVisualStyleBackColor = true;
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
			// ErrorDetailsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._detailsTabControl);
			this.Name = "SearchErrorDetailsView";
			this.Size = new System.Drawing.Size(612, 386);
			this._detailsTabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this._messageTabPage.ResumeLayout(false);
			this._messageTabPage.PerformLayout();
			this._detailsTabPage.ResumeLayout(false);
			this._detailsTabPage.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl _detailsTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label _typeLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label _timeLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label _hostLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label _sourceLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage _messageTabPage;
		private System.Windows.Forms.TabPage _detailsTabPage;
		private System.Windows.Forms.TextBox _messageTextBox;
		private System.Windows.Forms.TextBox _detailsTextBox;
		private System.Windows.Forms.ListView _servervariablesListView;
		private System.Windows.Forms.ColumnHeader _nameColumnHeader;
		private System.Windows.Forms.ColumnHeader _valueColumnHeader;
		private System.Windows.Forms.Label _userLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label _urlLabel;
		private System.Windows.Forms.Label label6;
	}
}
