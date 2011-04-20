namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	partial class SearchFilterView
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
			this._sourceComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this._usersComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this._searchButton = new System.Windows.Forms.Button();
			this._textTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._typeComboBox = new System.Windows.Forms.ComboBox();
			this.dateIntervalView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.DateIntervalView();
			this.SuspendLayout();
			// 
			// _sourceComboBox
			// 
			this._sourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._sourceComboBox.FormattingEnabled = true;
			this._sourceComboBox.Location = new System.Drawing.Point(61, 44);
			this._sourceComboBox.Name = "_sourceComboBox";
			this._sourceComboBox.Size = new System.Drawing.Size(307, 21);
			this._sourceComboBox.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Source:";
			// 
			// _usersComboBox
			// 
			this._usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._usersComboBox.FormattingEnabled = true;
			this._usersComboBox.Location = new System.Drawing.Point(61, 72);
			this._usersComboBox.Name = "_usersComboBox";
			this._usersComboBox.Size = new System.Drawing.Size(307, 21);
			this._usersComboBox.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "User:";
			// 
			// _searchButton
			// 
			this._searchButton.Location = new System.Drawing.Point(791, 78);
			this._searchButton.Name = "_searchButton";
			this._searchButton.Size = new System.Drawing.Size(75, 23);
			this._searchButton.TabIndex = 12;
			this._searchButton.Text = "Search";
			this._searchButton.UseVisualStyleBackColor = true;
			this._searchButton.Click += new System.EventHandler(this.SearchButtonClick);
			// 
			// _textTextbox
			// 
			this._textTextbox.Location = new System.Drawing.Point(400, 60);
			this._textTextbox.Multiline = true;
			this._textTextbox.Name = "_textTextbox";
			this._textTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._textTextbox.Size = new System.Drawing.Size(385, 41);
			this._textTextbox.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(397, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Error message/Details contains:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type:";
			// 
			// _typeComboBox
			// 
			this._typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._typeComboBox.FormattingEnabled = true;
			this._typeComboBox.Location = new System.Drawing.Point(61, 13);
			this._typeComboBox.Name = "_typeComboBox";
			this._typeComboBox.Size = new System.Drawing.Size(307, 21);
			this._typeComboBox.TabIndex = 1;
			// 
			// dateIntervalView
			// 
			this.dateIntervalView.Location = new System.Drawing.Point(400, 14);
			this.dateIntervalView.Name = "dateIntervalView";
			this.dateIntervalView.Size = new System.Drawing.Size(291, 25);
			this.dateIntervalView.TabIndex = 13;
			// 
			// SearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateIntervalView);
			this.Controls.Add(this._sourceComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._usersComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._searchButton);
			this.Controls.Add(this._textTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._typeComboBox);
			this.Name = "SearchFilterView";
			this.Size = new System.Drawing.Size(879, 121);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _sourceComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox _usersComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button _searchButton;
		private System.Windows.Forms.TextBox _textTextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox _typeComboBox;
		private DateIntervalView dateIntervalView;



	}
}
