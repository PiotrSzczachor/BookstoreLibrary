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
    }
}
