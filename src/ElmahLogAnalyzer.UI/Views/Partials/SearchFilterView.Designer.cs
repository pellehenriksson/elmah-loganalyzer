using ElmahLogAnalyzer.UI.Controls;

namespace ElmahLogAnalyzer.UI.Views.Partials
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
			this._textTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._searchButton = new System.Windows.Forms.Button();
			this._usersSelector = new ElmahLogAnalyzer.UI.Controls.SelectorView();
			this._urlsSelector = new ElmahLogAnalyzer.UI.Controls.SelectorView();
			this._sourcesSelector = new ElmahLogAnalyzer.UI.Controls.SelectorView();
			this._typesSelector = new ElmahLogAnalyzer.UI.Controls.SelectorView();
			this._dateIntervalPicker = new ElmahLogAnalyzer.UI.Controls.DateIntervalPicker();
			this.label1 = new System.Windows.Forms.Label();
			this._applicationsComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// _textTextbox
			// 
			this._textTextbox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._textTextbox.Location = new System.Drawing.Point(476, 48);
			this._textTextbox.Name = "_textTextbox";
			this._textTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._textTextbox.Size = new System.Drawing.Size(405, 21);
			this._textTextbox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(311, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Error message/Details contains:";
			// 
			// _searchButton
			// 
			this._searchButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._searchButton.Image = global::ElmahLogAnalyzer.UI.Properties.Resources.find;
			this._searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._searchButton.Location = new System.Drawing.Point(898, 47);
			this._searchButton.Name = "_searchButton";
			this._searchButton.Size = new System.Drawing.Size(77, 23);
			this._searchButton.TabIndex = 5;
			this._searchButton.Text = "Search";
			this._searchButton.UseVisualStyleBackColor = true;
			this._searchButton.Click += new System.EventHandler(this.SearchButtonClick);
			// 
			// _usersSelector
			// 
			this._usersSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this._usersSelector.Caption = "Users";
			this._usersSelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._usersSelector.Location = new System.Drawing.Point(739, 76);
			this._usersSelector.Name = "_usersSelector";
			this._usersSelector.Size = new System.Drawing.Size(236, 254);
			this._usersSelector.TabIndex = 9;
			// 
			// _urlsSelector
			// 
			this._urlsSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this._urlsSelector.Caption = "Urls";
			this._urlsSelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._urlsSelector.Location = new System.Drawing.Point(498, 76);
			this._urlsSelector.Name = "_urlsSelector";
			this._urlsSelector.Size = new System.Drawing.Size(238, 254);
			this._urlsSelector.TabIndex = 8;
			// 
			// _sourcesSelector
			// 
			this._sourcesSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this._sourcesSelector.Caption = "Sources";
			this._sourcesSelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._sourcesSelector.Location = new System.Drawing.Point(254, 76);
			this._sourcesSelector.Name = "_sourcesSelector";
			this._sourcesSelector.Size = new System.Drawing.Size(238, 254);
			this._sourcesSelector.TabIndex = 7;
			// 
			// _typesSelector
			// 
			this._typesSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this._typesSelector.Caption = "Types";
			this._typesSelector.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._typesSelector.Location = new System.Drawing.Point(3, 76);
			this._typesSelector.Name = "_typesSelector";
			this._typesSelector.Size = new System.Drawing.Size(245, 254);
			this._typesSelector.TabIndex = 6;
			// 
			// _dateIntervalPicker
			// 
			this._dateIntervalPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._dateIntervalPicker.Location = new System.Drawing.Point(3, 36);
			this._dateIntervalPicker.Name = "_dateIntervalPicker";
			this._dateIntervalPicker.Size = new System.Drawing.Size(302, 42);
			this._dateIntervalPicker.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Application:";
			// 
			// _applicationsComboBox
			// 
			this._applicationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._applicationsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._applicationsComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._applicationsComboBox.FormattingEnabled = true;
			this._applicationsComboBox.Location = new System.Drawing.Point(78, 10);
			this._applicationsComboBox.Name = "_applicationsComboBox";
			this._applicationsComboBox.Size = new System.Drawing.Size(217, 21);
			this._applicationsComboBox.TabIndex = 1;
			// 
			// SearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._applicationsComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._usersSelector);
			this.Controls.Add(this._urlsSelector);
			this.Controls.Add(this._sourcesSelector);
			this.Controls.Add(this._typesSelector);
			this.Controls.Add(this._dateIntervalPicker);
			this.Controls.Add(this._searchButton);
			this.Controls.Add(this._textTextbox);
			this.Controls.Add(this.label2);
			this.Name = "SearchFilterView";
			this.Size = new System.Drawing.Size(984, 333);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _searchButton;
		private System.Windows.Forms.TextBox _textTextbox;
		private System.Windows.Forms.Label label2;
		private DateIntervalPicker _dateIntervalPicker;
		private SelectorView _typesSelector;
		private SelectorView _sourcesSelector;
		private SelectorView _urlsSelector;
		private SelectorView _usersSelector;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox _applicationsComboBox;



	}
}
