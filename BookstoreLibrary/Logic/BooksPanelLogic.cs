using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Entities;

namespace BookstoreLibrary.Logic
{
    public class BooksPanelLogic
    {
        public void fillTableWithBooksToBorrow(DataGridView booksTable, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                booksTable.DataSource = db.BooksToBorrow.Select(b => new { Id = b.Id, Title = b.Book.Title, Quantity = b.Quantity}).ToList();
                label.Text = "Books to borrow:";
            }
        }

        public void fillTableWithBooksToSell(DataGridView booksTable, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                booksTable.DataSource = db.BooksToSell.Select(b => new { Id = b.Id, Title = b.Book.Title, Price = b.Price, Currency = b.Currency, Quantity = b.Quantity}).ToList();
                label.Text = "Books to sell:";
            }
        }

        public void fillTableWithBorrowedBooks(DataGridView booksTable, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                booksTable.DataSource = db.BorrowedBooks.Select(b => new { Id = b.Id, Title = b.Book.Book.Title, BorrowedBy = b.BorrowedBy.Username, BorrowedDate = b.BorrowedDate, DeadlineDate = b.DeadlineDate }).ToList();
                label.Text = "Borrowed books:";
            }

        }

        public void fillTableWithSoldBooks(DataGridView booksTable, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                booksTable.DataSource = db.SoldBooks.Select(b => new { Id = b.Id, Title = b.Book.Book.Title, Buyer = b.Buyer.Username, SoldDate = b.SoldDate, IsShipped = b.isShipped }).ToList();
                label.Text = "Sold books";
            }
        }
    }
}
