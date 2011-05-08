namespace Crepido.ElmahOfflineViewer.UI.Controls
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
			this.modeComboBox = new System.Windows.Forms.ComboBox();
			this.allButton = new System.Windows.Forms.Button();
			this.noneButton = new System.Windows.Forms.Button();
			this._itemsListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._itemsListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._itemsListContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// modeComboBox
			// 
			this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modeComboBox.FormattingEnabled = true;
			this.modeComboBox.Location = new System.Drawing.Point(3, 3);
			this.modeComboBox.Name = "modeComboBox";
			this.modeComboBox.Size = new System.Drawing.Size(97, 21);
			this.modeComboBox.TabIndex = 0;
			// 
			// allButton
			// 
			this.allButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allButton.Location = new System.Drawing.Point(3, 160);
			this.allButton.Name = "allButton";
			this.allButton.Size = new System.Drawing.Size(46, 20);
			this.allButton.TabIndex = 2;
			this.allButton.Text = "All";
			this.allButton.UseVisualStyleBackColor = true;
			this.allButton.Click += new System.EventHandler(this.AllButtonClick);
			// 
			// noneButton
			// 
			this.noneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noneButton.Location = new System.Drawing.Point(55, 160);
			this.noneButton.Name = "noneButton";
			this.noneButton.Size = new System.Drawing.Size(45, 20);
			this.noneButton.TabIndex = 3;
			this.noneButton.Text = "None";
			this.noneButton.UseVisualStyleBackColor = true;
			this.noneButton.Click += new System.EventHandler(this.NoneButtonClick);
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
			this._itemsListContextMenu.Size = new System.Drawing.Size(134, 26);
			this._itemsListContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemsListContextMenuItemClicked);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.copyToolStripMenuItem.Text = "Copy value";
			// 
			// SelectorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._itemsListView);
			this.Controls.Add(this.noneButton);
			this.Controls.Add(this.allButton);
			this.Controls.Add(this.modeComboBox);
			this.Name = "SelectorView";
			this.Size = new System.Drawing.Size(234, 182);
			this._itemsListContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox modeComboBox;
		private System.Windows.Forms.Button allButton;
		private System.Windows.Forms.Button noneButton;
		private System.Windows.Forms.ListView _itemsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ContextMenuStrip _itemsListContextMenu;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;


	}
}
