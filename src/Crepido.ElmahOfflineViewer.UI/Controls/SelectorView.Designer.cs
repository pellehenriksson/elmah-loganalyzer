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
			this.modeComboBox = new System.Windows.Forms.ComboBox();
			this.itemsListBox = new System.Windows.Forms.CheckedListBox();
			this.allButton = new System.Windows.Forms.Button();
			this.noneButton = new System.Windows.Forms.Button();
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
			// itemsListBox
			// 
			this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemsListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.itemsListBox.FormattingEnabled = true;
			this.itemsListBox.Location = new System.Drawing.Point(3, 30);
			this.itemsListBox.Name = "itemsListBox";
			this.itemsListBox.Size = new System.Drawing.Size(228, 124);
			this.itemsListBox.TabIndex = 1;
			// 
			// allButton
			// 
			this.allButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
			this.noneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.noneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noneButton.Location = new System.Drawing.Point(55, 160);
			this.noneButton.Name = "noneButton";
			this.noneButton.Size = new System.Drawing.Size(45, 20);
			this.noneButton.TabIndex = 3;
			this.noneButton.Text = "None";
			this.noneButton.UseVisualStyleBackColor = true;
			this.noneButton.Click += new System.EventHandler(this.NoneButtonClick);
			// 
			// SelectorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.noneButton);
			this.Controls.Add(this.allButton);
			this.Controls.Add(this.itemsListBox);
			this.Controls.Add(this.modeComboBox);
			this.Name = "SelectorView";
			this.Size = new System.Drawing.Size(234, 182);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox modeComboBox;
		private System.Windows.Forms.CheckedListBox itemsListBox;
		private System.Windows.Forms.Button allButton;
		private System.Windows.Forms.Button noneButton;


	}
}
