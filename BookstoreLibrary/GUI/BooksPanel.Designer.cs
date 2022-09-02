namespace BookstoreLibrary.GUI
{
    partial class BooksPanel
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
            this.BooksTable = new System.Windows.Forms.DataGridView();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToSellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToBorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BooksTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BooksTable
            // 
            this.BooksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksTable.Location = new System.Drawing.Point(12, 74);
            this.BooksTable.Name = "BooksTable";
            this.BooksTable.Size = new System.Drawing.Size(759, 319);
            this.BooksTable.TabIndex = 0;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 399);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(100, 39);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allBooksToolStripMenuItem,
            this.booksToSellToolStripMenuItem,
            this.booksToBorrowToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // allBooksToolStripMenuItem
            // 
            this.allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            this.allBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allBooksToolStripMenuItem.Text = "All books";
            this.allBooksToolStripMenuItem.Click += new System.EventHandler(this.allBooksToolStripMenuItem_Click);
            // 
            // booksToSellToolStripMenuItem
            // 
            this.booksToSellToolStripMenuItem.Name = "booksToSellToolStripMenuItem";
            this.booksToSellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.booksToSellToolStripMenuItem.Text = "Books to sell";
            this.booksToSellToolStripMenuItem.Click += new System.EventHandler(this.booksToSellToolStripMenuItem_Click);
            // 
            // booksToBorrowToolStripMenuItem
            // 
            this.booksToBorrowToolStripMenuItem.Name = "booksToBorrowToolStripMenuItem";
            this.booksToBorrowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.booksToBorrowToolStripMenuItem.Text = "Books to borrow";
            this.booksToBorrowToolStripMenuItem.Click += new System.EventHandler(this.booksToBorrowToolStripMenuItem_Click);
            // 
            // BooksTypeLabel
            // 
            this.BooksTypeLabel.AutoSize = true;
            this.BooksTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BooksTypeLabel.Location = new System.Drawing.Point(357, 53);
            this.BooksTypeLabel.Name = "BooksTypeLabel";
            this.BooksTypeLabel.Size = new System.Drawing.Size(52, 18);
            this.BooksTypeLabel.TabIndex = 3;
            this.BooksTypeLabel.Text = "label1";
            // 
            // BooksPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.BooksTypeLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.BooksTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BooksPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksPanel";
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksTable;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToSellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToBorrowToolStripMenuItem;
        private System.Windows.Forms.Label BooksTypeLabel;
    }
}