using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;
using BookstoreLibrary.Logic;

namespace BookstoreLibrary.GUI
{
    public partial class BooksPanelForm : Form
    {
        User currentlyLoggedUser;
        public BooksPanelForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            Initializer initializer = new Initializer();
            initializer.initBooksPanel(BooksTable, BooksTypeLabel);
            BooksTypeLabel.Left = (this.Width - BooksTypeLabel.Width) / 2;
            if (currentlyLoggedUser.Role.IsUser)
            {
                AddButton.Visible = false;
                EditButton.Visible = false;
                DeleteButton.Visible = false;
            }
            ToolStripMenuItem filters = (ToolStripMenuItem)menuStrip1.Items[0];
            foreach (ToolStripMenuItem item in filters.DropDownItems)
            {
                if (item.Text == "Borrowed books" || item.Text == "Sold books")
                {
                    item.Visible = false;
                }
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanelForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void booksToSellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksPanelLogic booksPanelLogic = new BooksPanelLogic();
            booksPanelLogic.fillTableWithBooksToSell(BooksTable, BooksTypeLabel);
            BooksTypeLabel.Left = (this.Width - BooksTypeLabel.Width) / 2;
        }

        private void booksToBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksPanelLogic booksPanelLogic = new BooksPanelLogic();
            booksPanelLogic.fillTableWithBooksToBorrow(BooksTable, BooksTypeLabel);
            BooksTypeLabel.Left = (this.Width - BooksTypeLabel.Width) / 2;
        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initializer initializer = new Initializer();
            initializer.initBooksPanel(BooksTable, BooksTypeLabel);
            BooksTypeLabel.Left = (this.Width - BooksTypeLabel.Width) / 2;
        }

        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksPanelLogic booksPanelLogic = new BooksPanelLogic();
            booksPanelLogic.fillTableWithBorrowedBooks(BooksTable, BooksTypeLabel);
            BooksTypeLabel.Left = (this.Width - BooksTypeLabel.Width) / 2;
        }

        private void soldBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksPanelLogic booksPanelLogic = new BooksPanelLogic();
            booksPanelLogic.fillTableWithSoldBooks(BooksTable, BooksTypeLabel);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddingBookForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", 
                                                  "Delete confirmation",
                                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int selectedrowindex = BooksTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = BooksTable.Rows[selectedrowindex];
                int bookId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                BooksManager booksManager = new BooksManager();
                if (BooksTypeLabel.Text.Contains("All"))
                {
                    booksManager.deleteBook(bookId);
                    Initializer initializer = new Initializer();
                    initializer.initBooksPanel(BooksTable, BooksTypeLabel);
                }
                else
                {
                    if (BooksTypeLabel.Text.Contains("sell"))
                    {
                        booksManager.deleteBookToSell(bookId);
                        BooksPanelLogic booksPanelLogic = new BooksPanelLogic();
                        booksPanelLogic.fillTableWithBooksToSell(BooksTable, BooksTypeLabel);
                    }
                    else
                    {
                        if (BooksTypeLabel.Text.Contains("borrow"))
                        {
                            booksManager.deleteBookToBorrow(bookId);
                            BooksPanelLogic booksPanelLogic = new BooksPanelLogic();
                            booksPanelLogic.fillTableWithBooksToBorrow(BooksTable, BooksTypeLabel);
                        }
                    }
                }
            }
        }
    }
}
