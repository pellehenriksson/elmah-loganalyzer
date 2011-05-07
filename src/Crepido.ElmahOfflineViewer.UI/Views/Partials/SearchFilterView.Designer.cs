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
			this._searchButton = new System.Windows.Forms.Button();
			this._textTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._usersSelectorView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SelectorView();
			this._urlsSelectorView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SelectorView();
			this._sourcesSelectorView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SelectorView();
			this._typeSelectorView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.SelectorView();
			this._dateIntervalView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.DateIntervalView();
			this.SuspendLayout();
			// 
			// _searchButton
			// 
			this._searchButton.Location = new System.Drawing.Point(1192, 158);
			this._searchButton.Name = "_searchButton";
			this._searchButton.Size = new System.Drawing.Size(75, 23);
			this._searchButton.TabIndex = 11;
			this._searchButton.Text = "Search";
			this._searchButton.UseVisualStyleBackColor = true;
			this._searchButton.Click += new System.EventHandler(this.SearchButtonClick);
			// 
			// _textTextbox
			// 
			this._textTextbox.Location = new System.Drawing.Point(984, 61);
			this._textTextbox.Multiline = true;
			this._textTextbox.Name = "_textTextbox";
			this._textTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._textTextbox.Size = new System.Drawing.Size(283, 91);
			this._textTextbox.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(981, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Error message/Details contains:";
			// 
			// _usersSelectorView
			// 
			this._usersSelectorView.Caption = "Users";
			this._usersSelectorView.Location = new System.Drawing.Point(739, 5);
			this._usersSelectorView.Name = "_usersSelectorView";
			this._usersSelectorView.Size = new System.Drawing.Size(236, 182);
			this._usersSelectorView.TabIndex = 7;
			// 
			// _urlsSelectorView
			// 
			this._urlsSelectorView.Caption = "Urls";
			this._urlsSelectorView.Location = new System.Drawing.Point(498, 5);
			this._urlsSelectorView.Name = "_urlsSelectorView";
			this._urlsSelectorView.Size = new System.Drawing.Size(238, 182);
			this._urlsSelectorView.TabIndex = 5;
			// 
			// _sourcesSelectorView
			// 
			this._sourcesSelectorView.Caption = "Sources";
			this._sourcesSelectorView.Location = new System.Drawing.Point(254, 5);
			this._sourcesSelectorView.Name = "_sourcesSelectorView";
			this._sourcesSelectorView.Size = new System.Drawing.Size(238, 182);
			this._sourcesSelectorView.TabIndex = 3;
			// 
			// _typeSelectorView
			// 
			this._typeSelectorView.Caption = "Types";
			this._typeSelectorView.Location = new System.Drawing.Point(3, 5);
			this._typeSelectorView.Name = "_typeSelectorView";
			this._typeSelectorView.Size = new System.Drawing.Size(245, 182);
			this._typeSelectorView.TabIndex = 1;
			// 
			// _dateIntervalView
			// 
			this._dateIntervalView.Location = new System.Drawing.Point(974, 0);
			this._dateIntervalView.Name = "_dateIntervalView";
			this._dateIntervalView.Size = new System.Drawing.Size(302, 29);
			this._dateIntervalView.TabIndex = 8;
			// 
			// SearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._usersSelectorView);
			this.Controls.Add(this._urlsSelectorView);
			this.Controls.Add(this._sourcesSelectorView);
			this.Controls.Add(this._typeSelectorView);
			this.Controls.Add(this._dateIntervalView);
			this.Controls.Add(this._searchButton);
			this.Controls.Add(this._textTextbox);
			this.Controls.Add(this.label2);
			this.Name = "SearchFilterView";
			this.Size = new System.Drawing.Size(1277, 193);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _searchButton;
		private System.Windows.Forms.TextBox _textTextbox;
		private System.Windows.Forms.Label label2;
		private DateIntervalView _dateIntervalView;
		private SelectorView _typeSelectorView;
		private SelectorView _sourcesSelectorView;
		private SelectorView _urlsSelectorView;
		private SelectorView _usersSelectorView;



	}
}
