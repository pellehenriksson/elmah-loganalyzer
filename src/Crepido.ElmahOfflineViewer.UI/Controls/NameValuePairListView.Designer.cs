namespace Crepido.ElmahOfflineViewer.UI.Controls
{
	partial class NameValuePairListView
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
			this._itemsListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._contextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// _itemsListView
			// 
			this._itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this._itemsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._itemsListView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._itemsListView.FullRowSelect = true;
			this._itemsListView.GridLines = true;
			this._itemsListView.Location = new System.Drawing.Point(0, 0);
			this._itemsListView.Name = "_itemsListView";
			this._itemsListView.ShowItemToolTips = true;
			this._itemsListView.Size = new System.Drawing.Size(613, 302);
			this._itemsListView.TabIndex = 2;
			this._itemsListView.UseCompatibleStateImageBehavior = false;
			this._itemsListView.View = System.Windows.Forms.View.Details;
			this._itemsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(ItemsListViewMouseClick);
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
			// _contextMenu
			// 
			this._contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyValueToolStripMenuItem});
			this._contextMenu.Name = "_contextMenu";
			this._contextMenu.Size = new System.Drawing.Size(134, 26);
			this._contextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuItemClicked);
			// 
			// copyValueToolStripMenuItem
			// 
			this.copyValueToolStripMenuItem.Name = "copyValueToolStripMenuItem";
			this.copyValueToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.copyValueToolStripMenuItem.Text = "Copy value";
			// 
			// NameValuePairListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._itemsListView);
			this.Name = "NameValuePairListView";
			this.Size = new System.Drawing.Size(613, 302);
			this._contextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView _itemsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ContextMenuStrip _contextMenu;
		private System.Windows.Forms.ToolStripMenuItem copyValueToolStripMenuItem;

	}
}
