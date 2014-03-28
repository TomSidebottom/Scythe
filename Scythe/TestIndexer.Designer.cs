namespace Scythe
{
	partial class TestIndexer
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.searchTermTextBox = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.resultListBox = new System.Windows.Forms.ListBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.termVectorListBox = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Search for:";
			// 
			// searchTermTextBox
			// 
			this.searchTermTextBox.Location = new System.Drawing.Point(75, 27);
			this.searchTermTextBox.Name = "searchTermTextBox";
			this.searchTermTextBox.Size = new System.Drawing.Size(506, 20);
			this.searchTermTextBox.TabIndex = 5;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(595, 25);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Search";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Search);
			// 
			// resultListBox
			// 
			this.resultListBox.DisplayMember = "Description";
			this.resultListBox.FormattingEnabled = true;
			this.resultListBox.Location = new System.Drawing.Point(23, 73);
			this.resultListBox.Name = "resultListBox";
			this.resultListBox.Size = new System.Drawing.Size(643, 173);
			this.resultListBox.TabIndex = 7;
			this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.DocSelected);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.indexToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(682, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newIndexToolStripMenuItem,
            this.openIndexToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newIndexToolStripMenuItem
			// 
			this.newIndexToolStripMenuItem.Name = "newIndexToolStripMenuItem";
			this.newIndexToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.newIndexToolStripMenuItem.Text = "New index...";
			this.newIndexToolStripMenuItem.Click += new System.EventHandler(this.NewIndexClicked);
			// 
			// openIndexToolStripMenuItem
			// 
			this.openIndexToolStripMenuItem.Name = "openIndexToolStripMenuItem";
			this.openIndexToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.openIndexToolStripMenuItem.Text = "Open index...";
			this.openIndexToolStripMenuItem.Click += new System.EventHandler(this.OpenIndexClicked);
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem});
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.indexToolStripMenuItem.Text = "Index";
			// 
			// addFilesToolStripMenuItem
			// 
			this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
			this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.addFilesToolStripMenuItem.Text = "Add files...";
			this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.IndexNewFiles);
			// 
			// termVectorListBox
			// 
			this.termVectorListBox.FormattingEnabled = true;
			this.termVectorListBox.Location = new System.Drawing.Point(23, 253);
			this.termVectorListBox.Name = "termVectorListBox";
			this.termVectorListBox.Size = new System.Drawing.Size(643, 186);
			this.termVectorListBox.TabIndex = 11;
			// 
			// TestIndexer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 452);
			this.Controls.Add(this.termVectorListBox);
			this.Controls.Add(this.resultListBox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.searchTermTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "TestIndexer";
			this.Text = "Test Indexer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox searchTermTextBox;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListBox resultListBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newIndexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openIndexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.ListBox termVectorListBox;
	}
}