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
    public partial class BooksPanel : Form
    {
        User currentlyLoggedUser;
        public BooksPanel(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            Initializer initializer = new Initializer();
            initializer.initBooksPanel(BooksTable, BooksTypeLabel);
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
        }

        private void booksToBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksPanelLogic booksPanelLogic = new BooksPanelLogic();
            booksPanelLogic.fillTableWithBooksToBorrow(BooksTable, BooksTypeLabel);
        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initializer initializer = new Initializer();
            initializer.initBooksPanel(BooksTable, BooksTypeLabel);
        }
    }
}
