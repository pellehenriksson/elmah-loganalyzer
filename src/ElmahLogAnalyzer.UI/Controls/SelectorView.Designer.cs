namespace ElmahLogAnalyzer.UI.Controls
{
	partial class SelectorView
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
			this.components = new System.ComponentModel.Container();
			this._modeComboBox = new System.Windows.Forms.ComboBox();
			this._allButton = new System.Windows.Forms.Button();
			this._noneButton = new System.Windows.Forms.Button();
			this._itemsListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._itemsListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._itemsListContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// _modeComboBox
			// 
			this._modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._modeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._modeComboBox.FormattingEnabled = true;
			this._modeComboBox.Location = new System.Drawing.Point(3, 3);
			this._modeComboBox.Name = "_modeComboBox";
			this._modeComboBox.Size = new System.Drawing.Size(97, 21);
			this._modeComboBox.TabIndex = 0;
			// 
			// _allButton
			// 
			this._allButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._allButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._allButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._allButton.Location = new System.Drawing.Point(3, 160);
			this._allButton.Name = "_allButton";
			this._allButton.Size = new System.Drawing.Size(46, 25);
			this._allButton.TabIndex = 2;
			this._allButton.Text = "All";
			this._allButton.UseVisualStyleBackColor = true;
			this._allButton.Click += new System.EventHandler(this.AllButtonClick);
			// 
			// _noneButton
			// 
			this._noneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._noneButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._noneButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._noneButton.Location = new System.Drawing.Point(55, 160);
			this._noneButton.Name = "_noneButton";
			this._noneButton.Size = new System.Drawing.Size(45, 25);
			this._noneButton.TabIndex = 3;
			this._noneButton.Text = "None";
			this._noneButton.UseVisualStyleBackColor = true;
			this._noneButton.Click += new System.EventHandler(this.NoneButtonClick);
			// 
			// _itemsListView
			// 
			this._itemsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._itemsListView.CheckBoxes = true;
			this._itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this._itemsListView.Location = new System.Drawing.Point(3, 30);
			this._itemsListView.MultiSelect = false;
			this._itemsListView.Name = "_itemsListView";
			this._itemsListView.ShowItemToolTips = true;
			this._itemsListView.Size = new System.Drawing.Size(228, 124);
			this._itemsListView.TabIndex = 4;
			this._itemsListView.UseCompatibleStateImageBehavior = false;
			this._itemsListView.View = System.Windows.Forms.View.Details;
			this._itemsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ItemsListViewMouseClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
			this.columnHeader1.Width = 200;
			// 
			// _itemsListContextMenu
			// 
			this._itemsListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
			this._itemsListContextMenu.Name = "_itemsListContextMenu";
			this._itemsListContextMenu.Size = new System.Drawing.Size(129, 26);
			this._itemsListContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemsListContextMenuItemClicked);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.copyToolStripMenuItem.Text = "Copy value";
			// 
			// SelectorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._itemsListView);
			this.Controls.Add(this._noneButton);
			this.Controls.Add(this._allButton);
			this.Controls.Add(this._modeComboBox);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "SelectorView";
			this.Size = new System.Drawing.Size(234, 187);
			this._itemsListContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox _modeComboBox;
		private System.Windows.Forms.Button _allButton;
		private System.Windows.Forms.Button _noneButton;
		private System.Windows.Forms.ListView _itemsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ContextMenuStrip _itemsListContextMenu;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;


	}
}
